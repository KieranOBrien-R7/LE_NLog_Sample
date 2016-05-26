using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace LogentriesNlogSampleApp
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            int n = 0;
            while (true)
            {
                logger.Debug(n);
                logger.Info(n+1);
                logger.Warn(n+2);
                n = n + 3;
            }
            String a = System.Console.ReadLine();
        }
    }
}
