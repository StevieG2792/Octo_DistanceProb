using DistanceProb_API.Interface;

namespace DistanceProb_API.Processor
{
    public class UomM : IUnitsOfMeasurement
    {
        public double ConvertFromKilometers(double value)
        {

            return value * .62137;

        }
    }
}
