using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orleans.DI.ConsoleHost;
using Orleans.Runtime.Configuration;
using Orleans.Runtime.Host;

namespace Orleans.DI
{
    class Program
    {
        static void Main(string[] args)
        {

            var siloConfig = ClusterConfiguration.LocalhostPrimarySilo();

            siloConfig.UseStartupType<Startup>();

            var silo = new SiloHost("Test Silo", siloConfig);
            silo.InitializeOrleansSilo();
            silo.StartOrleansSilo();

            Console.WriteLine("Press Enter to close.");
            // wait here
            Console.ReadLine();

            // shut the silo down after we are done.
            silo.ShutdownOrleansSilo();

        }
    }
}
