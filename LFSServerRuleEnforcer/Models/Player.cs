using InSimDotNet.Packets;

namespace LFSServerRuleEnforcer.Models
{
    public class Player
    {
        public byte UCID { get; set; }
        public byte PLID { get; set; }
        public string UName { get; set; }
        public string PName { get; set; }
        public PlayerFlags Flags { get; set; }
        public DateTime? IssueDetected { get; set; }
    }
}