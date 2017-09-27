using System;
using System.Threading.Tasks;

namespace Orleans.DI.Services
{
    public interface ICustomContainerBoundService
    {
        Task DoOtherThing();
    }

    public class CustomContainerBoundService : ICustomContainerBoundService
    {
        public Task DoOtherThing()
        {
            Console.WriteLine("DoOtherThing");
            return Task.CompletedTask;
        }
    }
}