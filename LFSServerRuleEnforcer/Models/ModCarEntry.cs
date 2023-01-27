// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
using Newtonsoft.Json;

namespace LFSServerRuleEnforcer.Models
{
    public class ModCarEntry
    {
        public string id { get; set; }
        public string name { get; set; }
        public string descriptionShort { get; set; }
        public string description { get; set; }
        public int userId { get; set; }
        public string userName { get; set; }
        public bool wip { get; set; }
        public int publishedAt { get; set; }
        public DateTime publishedAtDt => DateTimeOffset.FromUnixTimeSeconds(publishedAt).DateTime;
        public int numDownloads { get; set; }
        public int curUsage { get; set; }
        public float rating { get; set; }
        public int numRatings { get; set; }
        public int version { get; set; }
        public int lastDownloadedAt { get; set; }

        [JsonProperty("class")]
        public VehicleClass _class { get; set; }

        public bool ev { get; set; }
        public bool staffPick { get; set; }
        public bool tweakMod { get; set; }
        public ModVehicleDetails vehicle { get; set; }
    }

    public class ModVehicleDetails
    {
        public float iceCc { get; set; }
        public int iceNumCylinders { get; set; }
        public IceLayout iceLayout { get; set; }
        public float evRedLine { get; set; }
        public DriveType drive { get; set; }
        public ShiftType shiftType { get; set; }
        public float power { get; set; }
        public float maxPowerRpm { get; set; }
        public float torque { get; set; }
        public float maxTorqueRpm { get; set; }
        public float mass { get; set; }
        public float bhp { get; set; }
        public float powerWeightRatio { get; set; }
        public float bhpTon { get; set; }
        public float fuelTankSize { get; set; }
    }

    /*{
  "data": {
    "id":                 string  // Vehicle Mod identifier. AKA Skin ID, in HEX format
    "name":               string  // Vehicle Mod name
    "descriptionShort":   string  // Short description
    "description":        string  // Description
    "userId":             int     // Uploader user ID
    "userName":           string  // Uploader user Name
    "wip":                boolean // Work In Progress
    "publishedAt":        int     // Unixtimestamp of publish date
    "numDownloads":       int     // Number of downloads
    "curUsage":           int     // Number of racers using this mod online right now
    "rating":             int     // Rating, from 0 - 5
    "numRatings":         int     // Number of people who rated
    "version":            int     // Vehicle Mod Version
    "lastDownloadedAt":   int     // Unixtimestamp of last download date
    "class":              int     // Vehicle class
    "ev":                 boolean // Electric Vehicle if true
    "vehicle": {
      "iceCc":            int     // ICE cc
      "iceNumCylinders":  int     // ICE number of cylinders
      "iceLayout":        int     // ICE engine layout
      "evRedLine":        float   // EV redline
      "drive":            int     // Drive
      "shiftType":        int     // Shift type
      "power":            float   // Power in kW
      "maxPowerRpm":      int     // Max power at RPM
      "torque":           float   // Torque in Nm
      "maxTorqueRpm":     int     // Max torque at RPM
      "mass":             float   // Total mass of vehicle in kg
      "bhp":              float   // BHP
      "powerWightRatio":  float   // Power to weight ratio
      "bhpTon":           float   // BHP per ton
      "fuelTankSize":     float   // Fuel tank size. If "ev" = true, its unit is kWh, otherwise litres
    }
  }
}

    /* "class":
    0: Object
    1: Touring car
    2: Saloon car
    3: Buggy
    4: Formula
    5: GT
    6: Kart
    7: Bike
    8: Van
    9: Truck
    10: Formula 1
    11: Formula SAE */

    public enum VehicleClass
    { Object = 0, Touring = 1, Saloon = 2, Buggy = 3, Formula = 4, GT = 5, Kart = 6, Bike = 7, Van = 8, Truck = 9, Formula1 = 10, FormulaSAE = 11 }

    /* "iceLayout":
    0: inline
    1: flat
    2: V */

    public enum IceLayout
    { Inline = 0, Flat = 1, V = 2 }

    /* "drive":
    0: None
    1: Rear wheel drive
    2: Front wheel drive
    3: All wheel drive */

    public enum DriveType
    { None = 0, Rear = 1, Front = 2, All = 3 }

    /* "shiftType":
    0: None
    1: H-pattern gearbox
    2: Motorbike
    3: Sequential
    4: Sequential with ignition cut
    5: Paddle
    6: Electric motor
    7: Centrifugal clutch */

    public enum ShiftType
    { None = 0, HPattern = 1, Motorbike = 2, Sequential = 3, SequentialIgnitionCut = 4, Paddle = 5, Electric = 6, Centrifugal = 7 }
}
