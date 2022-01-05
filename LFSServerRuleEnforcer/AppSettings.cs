using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFSServerRuleEnforcer
{
    public class AppSettings
    {
        public ServerSettings Server { get; set; }
        public int SettingFixingPeriodSeconds { get; set; }
    }

    public class ServerSettings
    {
        public string Admin { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
    }
}
