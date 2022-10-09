using DistanceProb_API.Models;

namespace DistanceProb_API.Interface
{
    public interface ICalculation
    {
       public Task<double> CalculateDistance(DistanceInput input);
    }
}
