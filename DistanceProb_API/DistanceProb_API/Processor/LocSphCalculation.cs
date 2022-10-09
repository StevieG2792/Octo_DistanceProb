using DistanceProb_API.Interface;
using DistanceProb_API.Models;
using Microsoft.Net.Http.Headers;

namespace DistanceProb_API.Processor
{
    public class LocSphCalculation: ICalculation
    {

        private readonly double radius = 6371;

        //law of cosines -spherical earth
        public async Task<double> CalculateDistance(DistanceInput input)
        {
            var a = Math.PI * input.BaseLatitude / 180;
            var b = Math.PI * input.TargetLatitude / 180;
            var c = input.BaseLongtitude - input.TargetLongtitude;
            var d = Math.PI * c / 180;

            double distance = Math.Sin(a) * Math.Sin(b) + Math.Cos(a) * Math.Cos(b) * Math.Cos(d);
            distance = Math.Acos(distance);
            distance = distance * radius;
            return distance; 
        }

    }
}
