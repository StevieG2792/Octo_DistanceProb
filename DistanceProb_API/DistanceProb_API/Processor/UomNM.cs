using DistanceProb_API.Interface;

namespace DistanceProb_API.Processor
{
    public class UomNM : IUnitsOfMeasurement
    {
        public double ConvertFromKilometers(double value)
        {

            return value * .539957;

        }
    }
}
