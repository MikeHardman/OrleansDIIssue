using System.Threading.Tasks;

namespace Orleans.DI.GrainInterfaces
{
    public interface IGrainWithDefaultContainerService : IGrainWithIntegerKey
    {
        Task DoThing();
    }
}