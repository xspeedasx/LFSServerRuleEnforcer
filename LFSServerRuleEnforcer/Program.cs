using InSimDotNet;
using InSimDotNet.Packets;
using LFSServerRuleEnforcer;
using LFSServerRuleEnforcer.Models;
using Microsoft.Extensions.Configuration;

var players = new Dictionary<byte, Player>();
var insim = new InSimClient();
var builder = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", false, true);

var config = builder.Build();
var appSettings = config.GetSection("AppSettings").Get<AppSettings>();

using var timer = new System.Timers.Timer(1000);
timer.Elapsed += async (o, e) => { await Tick(o, e); };
timer.Start();

insim.IS_CPR += (o, e) => { Renamed(o, e); };
insim.IS_NCN += (o, e) => { NewConn(o, e); };
insim.IS_NPL += (o, e) => { NewPlayer(o, e); };
insim.IS_PFL += (o, e) => { PlayerFlagChange(o, e); };
insim.IS_PLL += (o, e) => { PlayerLeave(o, e); };
insim.IS_CNL += (o, e) => { ConnLeave(o, e); };
insim.IS_TOC += (o, e) => { TakeOverCar(o, e); };
insim.IS_ISM += (o, e) => { global::System.Console.WriteLine($"Insim connected to: {e.Packet.HName}"); };

await insim.InitializeAsync(new InSimSettings
{
    Admin = appSettings.Server.Admin,
    Host = appSettings.Server.Host,
    Port = appSettings.Server.Port,
    IName = "^3SS Enf",
    Flags = InSimFlags.ISF_MSO_COLS
});

await insim.SendAsync(TinyType.TINY_NCN);
await insim.SendAsync(TinyType.TINY_NPL);
await insim.SendAsync(TinyType.TINY_ISM);

while (insim.IsConnected) 
{ 
    Console.ReadKey();
}
Console.WriteLine("end.");


Player? GetByUcid(byte ucid)
{
    var p = players == null ? null : players.ContainsKey(ucid) ? players[ucid] : null;
    return p;
}

Player? GetByPlid(byte plid)
{
    var p = players.FirstOrDefault(x => x.Value?.PLID == plid);
    return p.Value;
}

async Task Tick(object? sender, System.Timers.ElapsedEventArgs e)
{
    foreach (var (ucid, p) in players)
    {
        if(p == null) continue;
        await CheckFlags(p, p.Flags, "[Tick]");
        if(p.IssueDetected <= DateTime.Now.AddSeconds(-appSettings.SettingFixingPeriodSeconds))
        {
            p.IssueDetected = null;
            await insim.SendAsync("/spec " + p.UName);
            await insim.SendAsync($"{p.PName} ^3has been spectated for not complying with clutch usage rules");
        }
    }
}

void NewConn(object o, PacketEventArgs<IS_NCN> e)
{
    var ncn = e.Packet;
    players[ncn.UCID] = new Player
    {
        UCID = ncn.UCID,
        UName = ncn.UName,
        PName = ncn.PName
    };
}

void NewPlayer(object o, PacketEventArgs<IS_NPL> e)
{
    var npl = e.Packet;
    var p = GetByUcid(npl.UCID);
    if(p == null) return;
    p.PName = npl.PName;
    p.PLID = npl.PLID;
    
    var flags = npl.Flags;
    p.Flags = flags;
}

void TakeOverCar(object o, PacketEventArgs<IS_TOC> e)
{
    var toc = e.Packet;
    var newPl = GetByUcid(toc.NewUCID);
    var oldPl = GetByUcid(toc.OldUCID);

    if (newPl != null)
        newPl.PLID = toc.PLID;

    if (oldPl != null)
        oldPl.PLID = 0;
}

void Renamed(object o, PacketEventArgs<IS_CPR> e)
{
    var cpr = e.Packet;
    var p = GetByUcid(cpr.UCID);
    if (p == null) return;
    p.PName = cpr.PName;
}

void PlayerFlagChange(object o, PacketEventArgs<IS_PFL> e)
{
    var pfl = e.Packet;
    var p = GetByPlid(pfl.PLID);
    if (p == null) return;
    var flags = pfl.Flags;
    p.Flags = flags;
}

void PlayerLeave(object o, PacketEventArgs<IS_PLL> e)
{
    var pll = e.Packet;
    var p  = GetByPlid(pll.PLID);
    if (p == null) return;
    p.PLID = 0;
}

void ConnLeave(object o, PacketEventArgs<IS_CNL> e)
{
    var cnl = e.Packet;
    var p = GetByUcid(cnl.UCID);
    if (p == null) return;
    players.Remove(p.UCID);
}

async Task CheckFlags(Player p, PlayerFlags flags, string origin = "")
{
    if (p.PLID == 0) return;
    var autoClutch = (flags & PlayerFlags.PIF_AUTOCLUTCH) > 0;
    var clutchAxis = (flags & PlayerFlags.PIF_AXIS_CLUTCH) > 0;

    if (!autoClutch && !clutchAxis)
    {
        if (p.IssueDetected == null)
        {
            var secs = appSettings.SettingFixingPeriodSeconds;
            var period = secs < 60
                ? $"{secs} seconds"
                : secs < 3600 
                    ? $"{secs / 60} min{(secs % 60 > 0 ? $" {secs % 60} sec" : "")}" 
                    : TimeSpan.FromSeconds(secs).ToString();
            p.IssueDetected = DateTime.Now;
            await insim.SendAsync(p.UCID, $"^3Button clutch detected! You have ^7{period}^3 to fix your settings or you'll be spectated!");
        }
    }
    else
    {
        if(p.IssueDetected != null)
        {
            p.IssueDetected = null;
            await insim.SendAsync(p.UCID, $"^3Settings are now OK. Thanks for playing fair!");
        }
    }
}