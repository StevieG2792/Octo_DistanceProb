using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DistanceProb_API.Models
{
    public class DistanceInput
    {

        [RegularExpression("KM|M|NM", ErrorMessage = "The Unit of Measurement must be KM, M or NM")]
        public string Uom { get; set; }
        [RegularExpression("Spherical|Flat", ErrorMessage = "The Method must be Spherical or Flat")]
        public string Method { get; set; }
        [Range (0, 90, ErrorMessage = "Latitude can not exceed 90 degrees")]
        public double BaseLatitude { get; set; }
        [Range(0, 180, ErrorMessage = "Longtitude can not exceed 180 degrees")]
        public double BaseLongtitude { get; set; }
        [Range(0, 90, ErrorMessage = "Latitude can not exceed 90 degrees")]
        public double TargetLatitude { get; set; }
        [Range(0, 180, ErrorMessage = "Longtitude can not exceed 180 degrees")]
        public double TargetLongtitude { get; set; }
    }
}
