using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Orleans.DI.Services;

namespace Orleans.DI.ConsoleHost
{
    public class Startup
    {
        public IServiceProvider ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IDefaultContainerBoundService, DefaultContainerBoundService>();

            return new MockServiceProvider(serviceCollection.BuildServiceProvider());
        }        
    }

    public class MockServiceProvider : IServiceProvider
    {
        private readonly IServiceProvider _outerProvider;

        public MockServiceProvider(IServiceProvider outerProvider)
        {
            _outerProvider = outerProvider;            
        }

        public object GetService(Type serviceType)
        {
            return InnerGetService(serviceType) ?? _outerProvider.GetService(serviceType);
        }

        private object InnerGetService(Type serviceType)
        {
            if (serviceType == typeof(ICustomContainerBoundService))
            {
                return new CustomContainerBoundService();                
            }
            Console.WriteLine($"Unbound Service Request for Type:{serviceType}, passing it on");
            return null;
        }
    }
}
