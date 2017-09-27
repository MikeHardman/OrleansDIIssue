using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orleans.DI.GrainInterfaces;
using Orleans.Runtime.Configuration;

namespace Orleans.DI.TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var startTask = Start();
            startTask.Wait();
        }

        private static async Task Start()
        {
            var config = ClientConfiguration.LocalhostSilo();
            var builder = new ClientBuilder().UseConfiguration(config);
            var client = builder.Build();
            await client.Connect();



            var defaultGrain = client.GetGrain<IGrainWithDefaultContainerService>(0);
            await defaultGrain.DoThing();


            var customGrain = client.GetGrain<IGrainWithCustomContainerService>(0);
            await customGrain.DoOtherThing();

        }
    }
}
