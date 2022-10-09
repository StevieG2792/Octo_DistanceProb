using DistanceProb_API.Interface;
using DistanceProb_API.Models;

namespace DistanceProb_API.Processor
{
    public class ConvertToUom : IConvertToUom
    {
        public double Convert(IUnitsOfMeasurement method, double distance)
        {
            return method.ConvertFromKilometers(distance);
        }
    }
}
