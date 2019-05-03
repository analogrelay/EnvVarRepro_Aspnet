using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnvVarRepro_Aspnet
{
    public class LoggingOptions
    {
        private string _hostName;

        // Host name of the logging server
        public string HostName
        {
            get => string.IsNullOrWhiteSpace(_hostName) ? "localhost" : _hostName;
            set => _hostName = value;
        }
    }

    public class MetricsOptions
    {
        private string _hostName;

        // Host name of the metrics server
        public string HostName
        {
            get => string.IsNullOrWhiteSpace(_hostName) ? "localhost" : _hostName;
            set => _hostName = value;
        }
    }
}
