using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orleans.DI.GrainInterfaces
{
    public interface IGrainWithCustomContainerService : IGrainWithIntegerKey
    {
        Task DoOtherThing();
    }
}
