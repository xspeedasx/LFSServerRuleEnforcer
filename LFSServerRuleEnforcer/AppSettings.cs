namespace LFSServerRuleEnforcer
{
    public class AppSettings
    {
        public ServerSettings Server { get; set; }
        public int SettingFixingPeriodSeconds { get; set; }

        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string CarInfoCacheDirectory { get; set; }
    }

    public class ServerSettings
    {
        public string Admin { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
    }
}
