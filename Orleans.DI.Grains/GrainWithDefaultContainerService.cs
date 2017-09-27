using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orleans.DI.GrainInterfaces;
using Orleans.DI.Services;

namespace Orleans.DI.Grains
{    
    public class GrainWithDefaultContainerService : Grain, IGrainWithDefaultContainerService
    {
        private readonly IDefaultContainerBoundService _service;
        public GrainWithDefaultContainerService(IDefaultContainerBoundService service)
        {
            _service = service;
        }

        public Task DoThing()
        {
            return _service.DoThing();
        }
    }
}
