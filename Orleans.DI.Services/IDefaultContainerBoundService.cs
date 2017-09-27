using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orleans.DI.Services
{
    public interface IDefaultContainerBoundService
    {
        Task DoThing();
    }

    public class DefaultContainerBoundService : IDefaultContainerBoundService
    {
        public Task DoThing()
        {
            Console.WriteLine("DoThing");
            return Task.CompletedTask;
        }
    }
}
