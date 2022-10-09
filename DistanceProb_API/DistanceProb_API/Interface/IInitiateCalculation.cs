using DistanceProb_API.Models;

namespace DistanceProb_API.Interface
{
    public interface IInitiateCalculation
    {
      public Task<double> Calculate(ICalculation method, DistanceInput input);
    }
}
