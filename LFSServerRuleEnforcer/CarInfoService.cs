using System.Net;
using LFSServerRuleEnforcer.Models;
using Newtonsoft.Json;
using DriveType = LFSServerRuleEnforcer.Models.DriveType;

namespace LFSServerRuleEnforcer;

public class CarInfoService
{
    public static Dictionary<string, ModCarEntry> StandardCarInfo = new()
    {
        {
            "UF1",
            new ModCarEntry
            {
                id = "UF1",
                name = "UF 1000",
                _class = VehicleClass.Saloon,
                vehicle = new ModVehicleDetails
                {
                    iceCc = 1000,
                    iceNumCylinders = 4,
                    iceLayout = IceLayout.Inline,
                    evRedLine = 8000,
                    drive = DriveType.Front,
                    shiftType = ShiftType.HPattern,
                    power = 41,
                    maxPowerRpm = 5605,
                    torque = 88,
                    maxTorqueRpm = 3008,
                    mass = 600,
                    bhp = 55,
                    powerWeightRatio = 69,
                    bhpTon = 94,
                    fuelTankSize = 35
                }
            }
        },
        {
            "XFG",
            new ModCarEntry
            {
                id = "XFG",
                name = "XF GTI",
                _class = VehicleClass.Saloon,
                vehicle = new ModVehicleDetails
                {
                    iceCc = 1300,
                    iceNumCylinders = 4,
                    iceLayout = IceLayout.Inline,
                    evRedLine = 8000,
                    drive = DriveType.Front,
                    shiftType = ShiftType.HPattern,
                    power = 86,
                    maxPowerRpm = 7031,
                    torque = 130,
                    maxTorqueRpm = 5438,
                    mass = 942,
                    bhp = 115,
                    powerWeightRatio = 91,
                    bhpTon = 124,
                    fuelTankSize = 45
                }
            }
        },
        {
            "XRG",
            new ModCarEntry
            {
                id = "XRG",
                name = "XR GT",
                _class = VehicleClass.Saloon,
                vehicle = new ModVehicleDetails
                {
                    iceCc = 1800,
                    iceNumCylinders = 4,
                    iceLayout = IceLayout.Inline,
                    evRedLine = 8000,
                    drive = DriveType.Rear,
                    shiftType = ShiftType.HPattern,
                    power = 104,
                    maxPowerRpm = 5988,
                    torque = 187,
                    maxTorqueRpm = 4512,
                    mass = 1150,
                    bhp = 140,
                    powerWeightRatio = 91,
                    bhpTon = 124,
                    fuelTankSize = 65
                }
            }
        },
        {
            "LX4",
            new ModCarEntry
            {
                id = "LX4",
                name = "LX4",
                _class = VehicleClass.Saloon,
                vehicle = new ModVehicleDetails
                {
                    iceCc = 1300,
                    iceNumCylinders = 4,
                    iceLayout = IceLayout.Inline,
                    evRedLine = 9000,
                    drive = DriveType.Rear,
                    shiftType = ShiftType.HPattern,
                    power = 105,
                    maxPowerRpm = 8227,
                    torque = 131,
                    maxTorqueRpm = 6891,
                    mass = 499,
                    bhp = 140,
                    powerWeightRatio = 210,
                    bhpTon = 286,
                    fuelTankSize = 40
                }
            }
        },
        {
            "LX6",
            new ModCarEntry
            {
                id = "LX6",
                name = "LX6",
                _class = VehicleClass.Saloon,
                vehicle = new ModVehicleDetails
                {
                    iceCc = 1800,
                    iceNumCylinders = 6,
                    iceLayout = IceLayout.Inline,
                    evRedLine = 9000,
                    drive = DriveType.Rear,
                    shiftType = ShiftType.HPattern,
                    power = 142,
                    maxPowerRpm = 8402,
                    torque = 173,
                    maxTorqueRpm = 7066,
                    mass = 539,
                    bhp = 190,
                    powerWeightRatio = 263,
                    bhpTon = 358,
                    fuelTankSize = 40
                }
            }
        },
        {
            "RB4",
            new ModCarEntry
            {
                id = "RB4",
                name = "RB4 GT",
                _class = VehicleClass.Saloon,
                vehicle = new ModVehicleDetails
                {
                    iceCc = 2000,
                    iceNumCylinders = 4,
                    iceLayout = IceLayout.Inline,
                    evRedLine = 8000,
                    drive = DriveType.All,
                    shiftType = ShiftType.HPattern,
                    power = 181,
                    maxPowerRpm = 6035,
                    torque = 340,
                    maxTorqueRpm = 3896,
                    mass = 1210,
                    bhp = 243,
                    powerWeightRatio = 150,
                    bhpTon = 204,
                    fuelTankSize = 75
                }
            }
        },
        {
            "FXO",
            new ModCarEntry
            {
                id = "FXO",
                name = "FXO TURBO",
                _class = VehicleClass.Saloon,
                vehicle = new ModVehicleDetails
                {
                    iceCc = 1900,
                    iceNumCylinders = 4,
                    iceLayout = IceLayout.Flat,
                    evRedLine = 8000,
                    drive = DriveType.Front,
                    shiftType = ShiftType.HPattern,
                    power = 175,
                    maxPowerRpm = 6357,
                    torque = 305,
                    maxTorqueRpm = 4336,
                    mass = 1136,
                    bhp = 234,
                    powerWeightRatio = 154,
                    bhpTon = 210,
                    fuelTankSize = 75
                }
            }
        },
        {
            "XRT",
            new ModCarEntry
            {
                id = "XRT",
                name = "XR GT TURBO",
                _class = VehicleClass.Saloon,
                vehicle = new ModVehicleDetails
                {
                    iceCc = 2000,
                    iceNumCylinders = 4,
                    iceLayout = IceLayout.Inline,
                    evRedLine = 8000,
                    drive = DriveType.Rear,
                    shiftType = ShiftType.HPattern,
                    power = 184,
                    maxPowerRpm = 6035,
                    torque = 345,
                    maxTorqueRpm = 3896,
                    mass = 1223,
                    bhp = 255,
                    powerWeightRatio = 151,
                    bhpTon = 205,
                    fuelTankSize = 75
                }
            }
        },
        {
            "RAC",
            new ModCarEntry
            {
                id = "RAC",
                name = "RACEABOUT",
                _class = VehicleClass.Saloon,
                vehicle = new ModVehicleDetails
                {
                    iceCc = 2000,
                    iceNumCylinders = 4,
                    iceLayout = IceLayout.Inline,
                    evRedLine = 8000,
                    drive = DriveType.Rear,
                    shiftType = ShiftType.HPattern,
                    power = 183,
                    maxPowerRpm = 5906,
                    torque = 360,
                    maxTorqueRpm = 3500,
                    mass = 800,
                    bhp = 245,
                    powerWeightRatio = 228,
                    bhpTon = 311,
                    fuelTankSize = 42
                }
            }
        },
        {
            "FZ5",
            new ModCarEntry
            {
                id = "FZ5",
                name = "FZ50",
                _class = VehicleClass.Saloon,
                vehicle = new ModVehicleDetails
                {
                    iceCc = 3600,
                    iceNumCylinders = 6,
                    iceLayout = IceLayout.Flat,
                    evRedLine = 8000,
                    drive = DriveType.Rear,
                    shiftType = ShiftType.HPattern,
                    power = 269,
                    bhp = 360,
                    maxPowerRpm = 7563,
                    torque = 392,
                    maxTorqueRpm = 5000,
                    mass = 1380,
                    powerWeightRatio = 195,
                    bhpTon = 265,
                    fuelTankSize = 90
                }
            }
        },
        {
            "UFR",
            new ModCarEntry
            {
                id = "UFR",
                name = "UF GTR",
                _class = VehicleClass.Saloon,
                vehicle = new ModVehicleDetails
                {
                    iceCc = 1400,
                    iceNumCylinders = 4,
                    iceLayout = IceLayout.Inline,
                    evRedLine = 9000,
                    drive = DriveType.Front,
                    shiftType = ShiftType.HPattern,
                    power = 134,
                    bhp = 180,
                    maxPowerRpm = 8227,
                    torque = 178,
                    maxTorqueRpm = 5871,
                    mass = 600,
                    powerWeightRatio = 223,
                    bhpTon = 304,
                    fuelTankSize = 60
                }
            }
        },
        {
            "XFR",
            new ModCarEntry
            {
                id = "XFR",
                name = "XF GTR",
                _class = VehicleClass.Saloon,
                vehicle = new ModVehicleDetails
                {
                    iceCc = 2000,
                    iceNumCylinders = 4,
                    iceLayout = IceLayout.Inline,
                    evRedLine = 8000,
                    drive = DriveType.Front,
                    shiftType = ShiftType.SequentialIgnitionCut,
                    power = 172,
                    bhp = 230,
                    maxPowerRpm = 7219,
                    torque = 260,
                    maxTorqueRpm = 5125,
                    mass = 840,
                    powerWeightRatio = 204,
                    bhpTon = 279,
                    fuelTankSize = 70
                }
            }
        },
        {
            "FXR",
            new ModCarEntry
            {
                id = "FXR",
                name = "FXO GTR",
                _class = VehicleClass.Saloon,
                vehicle = new ModVehicleDetails
                {
                    iceCc = 2000,
                    iceNumCylinders = 4,
                    iceLayout = IceLayout.Flat,
                    evRedLine = 7500,
                    drive = DriveType.All,
                    shiftType = ShiftType.SequentialIgnitionCut,
                    power = 365,
                    bhp = 490,
                    maxPowerRpm = 6270,
                    torque = 627,
                    maxTorqueRpm = 4775,
                    mass = 1100,
                    powerWeightRatio = 332,
                    bhpTon = 453,
                    fuelTankSize = 100
                }
            }
        },
        {
            "XRR",
            new ModCarEntry
            {
                id = "XRR",
                name = "XR GTR",
                _class = VehicleClass.Saloon,
                vehicle = new ModVehicleDetails
                {
                    iceCc = 2000,
                    iceNumCylinders = 4,
                    iceLayout = IceLayout.Inline,
                    evRedLine = 7500,
                    drive = DriveType.Rear,
                    shiftType = ShiftType.SequentialIgnitionCut,
                    power = 365,
                    bhp = 490,
                    maxPowerRpm = 6270,
                    torque = 627,
                    maxTorqueRpm = 4775,
                    mass = 1100,
                    powerWeightRatio = 332,
                    bhpTon = 453,
                    fuelTankSize = 100
                }
            }
        },
        {
            "FZR",
            new ModCarEntry
            {
                id = "FZR",
                name = "FZ50 GTR",
                _class = VehicleClass.Saloon,
                vehicle = new ModVehicleDetails
                {
                    iceCc = 3600,
                    iceNumCylinders = 6,
                    iceLayout = IceLayout.Flat,
                    evRedLine = 8500,
                    drive = DriveType.Rear,
                    shiftType = ShiftType.HPattern,
                    power = 365,
                    bhp = 490,
                    maxPowerRpm = 8102,
                    torque = 503,
                    maxTorqueRpm = 5246,
                    mass = 1100,
                    powerWeightRatio = 332,
                    bhpTon = 452,
                    fuelTankSize = 100
                }
            }
        },
        {
            "MRT",
            new ModCarEntry
            {
                id = "MRT",
                name = "MRT5",
                _class = VehicleClass.Kart,
                vehicle = new ModVehicleDetails
                {
                    iceCc = 600,
                    iceNumCylinders = 4,
                    iceLayout = IceLayout.Inline,
                    evRedLine = 8500,
                    drive = DriveType.Rear,
                    shiftType = ShiftType.Motorbike,
                    power = 48,
                    bhp = 64,
                    maxPowerRpm = 7871,
                    torque = 69,
                    maxTorqueRpm = 5078,
                    mass = 222,
                    powerWeightRatio = 216,
                    bhpTon = 295,
                    fuelTankSize = 20
                }
            }
        },
        {
            "FBM",
            new ModCarEntry
            {
                id = "FBM",
                name = "FORMULA BMW FB02",
                _class = VehicleClass.FormulaSAE,
                vehicle = new ModVehicleDetails
                {
                    iceCc = 1200,
                    iceNumCylinders = 4,
                    iceLayout = IceLayout.Inline,
                    evRedLine = 9500,
                    drive = DriveType.Rear,
                    shiftType = ShiftType.Sequential,
                    power = 105,
                    bhp = 140,
                    maxPowerRpm = 8948,
                    torque = 125,
                    maxTorqueRpm = 6756,
                    mass = 465,
                    powerWeightRatio = 225,
                    bhpTon = 307,
                    fuelTankSize = 42
                }
            }
        },
        {
            "FOX",
            new ModCarEntry
            {
                id = "FOX",
                name = "FORMULA XR",
                _class = VehicleClass.Formula,
                vehicle = new ModVehicleDetails
                {
                    iceCc = 2000,
                    iceNumCylinders = 4,
                    iceLayout = IceLayout.Inline,
                    evRedLine = 8000,
                    drive = DriveType.Rear,
                    shiftType = ShiftType.SequentialIgnitionCut,
                    power = 142,
                    bhp = 190,
                    maxPowerRpm = 7031,
                    torque = 221,
                    maxTorqueRpm = 4980,
                    mass = 490,
                    powerWeightRatio = 290,
                    bhpTon = 395,
                    fuelTankSize = 38
                }
            }
        },
        {
            "FO8",
            new ModCarEntry
            {
                id = "FO8",
                name = "FORMULA V8",
                _class = VehicleClass.Formula,
                vehicle = new ModVehicleDetails
                {
                    iceCc = 3000,
                    iceNumCylinders = 8,
                    iceLayout = IceLayout.V,
                    evRedLine = 9500,
                    drive = DriveType.Rear,
                    shiftType = ShiftType.SequentialIgnitionCut,
                    power = 335,
                    bhp = 450,
                    maxPowerRpm = 9092,
                    torque = 385,
                    maxTorqueRpm = 7422,
                    mass = 600,
                    powerWeightRatio = 559,
                    bhpTon = 762,
                    fuelTankSize = 125
                }
            }
        },
        {
            "BF1",
            new ModCarEntry
            {
                id = "BF1",
                name = "BMW SAUBER F1.06",
                _class = VehicleClass.Formula1,
                vehicle = new ModVehicleDetails
                {
                    iceCc = 2400,
                    iceNumCylinders = 8,
                    iceLayout = IceLayout.V,
                    evRedLine = 20000,
                    drive = DriveType.Rear,
                    shiftType = ShiftType.Paddle,
                    power = 537,
                    bhp = 720,
                    maxPowerRpm = 19063,
                    torque = 284,
                    maxTorqueRpm = 16797,
                    mass = 530,
                    powerWeightRatio = 1012,
                    bhpTon = 1378,
                    fuelTankSize = 95
                }
            }
        }
    };

    private readonly Dictionary<string, ModCarEntry> _carEntries;

    // public Dictionary<string, string> CarNames;
    private readonly string _carInfoCacheDirectory;
    private readonly AppSettings _appSettings;
    private string _accessToken = "";
    private DateTime _lastUpdated = DateTime.MinValue;
    private DateTime _tokenExpiration = DateTime.MinValue;

    private bool _updating;

    public CarInfoService(string carInfoCacheDirectory, AppSettings appSettings)
    {
        _carInfoCacheDirectory = carInfoCacheDirectory;
        _appSettings = appSettings;
        _carEntries = new Dictionary<string, ModCarEntry>();
        LoadLocalCache();
        // CarNames = _lbService.LoadCarNamesRegistry();
    }
    
    public ModCarEntry? GetModEntryById(string id)
    {
        if (string.IsNullOrEmpty(id))
            return null;

        if (id.Length == 3 && StandardCarInfo.GetValueOrDefault(id) is { } sci)
            return sci;

        return _carEntries.ContainsKey(id) 
            ? _carEntries[id]
            : null;
    }

    private void LoadLocalCache()
    {
        if (!Directory.Exists(_carInfoCacheDirectory))
            Directory.CreateDirectory(_carInfoCacheDirectory);

        string[] cacheFolders = Directory.GetDirectories(_carInfoCacheDirectory);
        //foreach (var folder in cacheFolders)
        Parallel.ForEach(cacheFolders, folder =>
        {
            try
            {
                string[] versions = Directory.GetFiles(folder);
                if (versions.Length == 0) return;
                string? newest = versions.MaxBy(x =>
                    int.TryParse(Path.GetFileNameWithoutExtension(x), out int version) ? version : 0);
                string modId = Path.GetFileNameWithoutExtension(folder);

                var modCarEntry = JsonConvert.DeserializeObject<ModCarEntry>(File.ReadAllText(newest!));
                if (modCarEntry is { })
                    _carEntries[modId] = modCarEntry;
                else
                    Console.Error.WriteLine($"Could not deserialize entry from {newest}");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error loading cache from {folder}");
            }
        });
    }

    public async Task UpdateCarInfos()
    {
        if (_updating || _lastUpdated.AddMinutes(15) > DateTime.Now) return;
        _updating = true;

        try
        {
            //2. load online metas
            List<ModCarEntry>? metas = await LoadOnlineMetas();
            if (metas == null) return;
            //3. compare local version to metas
            //4. and update discrepancies and write to cache

            // var metaIds = new List<string>();
            //foreach (ModCarEntry modMeta in metas)

            var updateTasks = new List<Task>();
            Parallel.ForEach(metas, modMeta =>
            {
                // metaIds.Add(modMeta.id);
                if (_carEntries.ContainsKey(modMeta.id))
                {
                    ModCarEntry localVersion = _carEntries[modMeta.id];
                    if (localVersion.version < modMeta.version)
                    {
                        lock(updateTasks)
                            updateTasks.Add(UpdateCarEntry(modMeta));
                    }
                }
                else
                {
                    lock(updateTasks)
                        updateTasks.Add(UpdateCarEntry(modMeta));
                }
            });

            Task.WaitAll(updateTasks.ToArray());
            Console.WriteLine("All car entries updated.");
        }
        finally
        {
            _updating = false;
            _lastUpdated = DateTime.Now;
        }
    }

    private async Task<List<ModCarEntry>?> LoadOnlineMetas()
    {
        try
        {
            var client = new HttpClient();
            if (DateTime.Now > _tokenExpiration) await UpdateToken();

            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + _accessToken);
            string carEntriesResponse = await client.GetStringAsync("https://api.lfs.net/vehiclemod/");
            var responseResult = JsonConvert.DeserializeObject<ModCarEntriesResponse>(carEntriesResponse);
            return responseResult?.Data ?? null;
        }
        catch (Exception ex)
        {
            await Console.Error.WriteLineAsync("Error loading online metas.");
            return null;
        }
    }

    private async Task UpdateToken()
    {
        var content = new FormUrlEncodedContent(new Dictionary<string, string>
        {
            { "client_secret", _appSettings.ClientSecret },
            { "client_id", _appSettings.ClientId },
            { "grant_type", "client_credentials" }
        });

        var client = new HttpClient();
        HttpResponseMessage tokenResponse = await client.PostAsync("https://id.lfs.net/oauth2/access_token", content);
        string tokenText = await tokenResponse.Content.ReadAsStringAsync();
        var tokenObject = JsonConvert.DeserializeObject<TokenResponse>(tokenText);
        _accessToken = tokenObject!.access_token;
        _tokenExpiration = DateTime.Now.AddSeconds(tokenObject.expires_in);

        Console.WriteLine("Access token renewed");
    }
    
    public async Task UpdateCarEntry(ModCarEntry? modMeta)
    {
        if (modMeta == null) return;
        try
        {
            var client = new HttpClient();
            if (DateTime.Now > _tokenExpiration)
            {
                await UpdateToken();
            }
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + _accessToken);
            string modId = modMeta.id;
            string carDetailsResponse = await client.GetStringAsync($"https://api.lfs.net/vehiclemod/{modId}");
            ModCarEntry? carEntry = JsonConvert.DeserializeObject<ModCarDetailsResponse>(carDetailsResponse)?.Data;
            if (carEntry == null || carEntry.id == null) return;
            await UpdateLocalCache(carEntry);
            Console.WriteLine($"Car {modId}: {carEntry.name} - updated");
        }
        catch (Exception ex)
        {
            await Console.Error.WriteLineAsync($"Exception trying to update car entry {modMeta.id}. {ex}");
            if (ex is WebException we)
            {
                if(we.Response == null) return;
                await using Stream stream = we.Response.GetResponseStream();
                using var sr = new StreamReader(stream);
                string rtxt = await sr.ReadToEndAsync();
                Console.WriteLine("Response: rtxt");
            }
        }
    }

    public async Task UpdateLocalCache(ModCarEntry? modDetails)
    {
        if (modDetails == null) return;
        string modId = modDetails.id;
        _carEntries[modId] = modDetails;

        string modDir = Path.Combine(_carInfoCacheDirectory, $"{modId}");
        if (!Directory.Exists(modDir))
            Directory.CreateDirectory(modDir);

        int ver = modDetails.version;
        string verFilePath = Path.Combine(modDir, $"{ver}.json");
        await File.WriteAllTextAsync(verFilePath, JsonConvert.SerializeObject(modDetails, Formatting.Indented));
        Console.WriteLine($"Local cache updated: {verFilePath}");
    }
    
    private class ModCarDetailsResponse
    {
        public ModCarEntry Data { get; set; }
    }

    private class ModCarEntriesResponse
    {
        public List<ModCarEntry> Data { get; set; }
    }

    private class TokenResponse
    {
        public string token_type { get; set; }
        public int expires_in { get; set; }
        public string access_token { get; set; }
    }
}