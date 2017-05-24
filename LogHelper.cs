using log4net;
using log4net.Config;
using System;
using System.IO;
using System.Security;

[assembly: XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]
namespace Toolkits.Log {
    public static class LogHelper {

        static LogHelper() {
            XmlConfigurator.ConfigureAndWatch(new FileInfo("log4net.config"));
        }

        public static ILog Instance {
            get {
                return LogManager.GetLogger("Logger");
            }
        }
    }
}
