using DistanceProb_API.Interface;
using DistanceProb_API.Models;

namespace DistanceProb_API.Processor
{
    public class LocFlaCalculation : ICalculation
    {
        private readonly double radius = 6371;

        //law of cosines - flat earth
        public async Task<double> CalculateDistance(DistanceInput input)
        {
            var x = (Math.PI / 2) - (Math.PI * input.BaseLatitude / 180);
            var y = (Math.PI / 2) - (Math.PI * input.TargetLatitude / 180);
            var a = (Math.PI * input.TargetLongtitude) - (Math.PI * input.BaseLongtitude);
            var z = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) - 2 * x * y * Math.Cos(a));

            double distance = z * radius;

            return distance;
        }
    }
}

