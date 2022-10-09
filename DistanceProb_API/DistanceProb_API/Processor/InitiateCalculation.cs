using DistanceProb_API.Interface;
using DistanceProb_API.Models;

namespace DistanceProb_API.Processor
{
    public class InitiateCalculation : IInitiateCalculation
    {
        public Task <double> Calculate(ICalculation method, DistanceInput input)
        {
         return method.CalculateDistance(input);
        }
    }
}
