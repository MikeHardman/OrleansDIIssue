using System.Threading.Tasks;
using Orleans.DI.GrainInterfaces;
using Orleans.DI.Services;

namespace Orleans.DI.Grains
{
    public class GrainWithContainerService : Grain, IGrainWithCustomContainerService
    {
        private readonly ICustomContainerBoundService _service;
        public GrainWithContainerService(ICustomContainerBoundService service)
        {
            _service = service;
        }

        public Task DoOtherThing()
        {
            return _service.DoOtherThing();
        }
    }
}