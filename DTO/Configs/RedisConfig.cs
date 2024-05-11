using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterCity.Core.Configs
{
    public class RedisConfig
    {
        public const string SECTION = "RedisConfig";
        public string Host { get; set; }
        public string Port { get; set; }
        public string Password { get; set; }
    }
}
