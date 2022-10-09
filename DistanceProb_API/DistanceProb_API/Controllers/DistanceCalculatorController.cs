using DistanceProb_API.Interface;
using DistanceProb_API.Models;
using DistanceProb_API.Processor;
using Microsoft.AspNetCore.Mvc;

namespace DistanceProb_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DistanceController : ControllerBase
    {
        private readonly ILogger<DistanceController> _logger;
        private readonly IInitiateCalculation _InitiateCalculation;
        private readonly IConvertToUom _ConvertToUom;
        private ICalculation _CalculationSph;
        private ICalculation _CalculationFla;
        private IUnitsOfMeasurement _UnitsOfMeasurement;
        private IUnitsOfMeasurement _UnitsOfMeasurementNm;

        public DistanceController(ILogger<DistanceController> logger, IInitiateCalculation initiateCalculation,
             IConvertToUom _convertToUom)
        {
            _logger = logger;
            _InitiateCalculation = initiateCalculation;
            _ConvertToUom = _convertToUom;
        }

        [HttpPost(Name = "FindDistance")]
        public async Task<double> GetCoOrdinates(DistanceInput input)

        {
            _CalculationFla = new LocFlaCalculation();
            _CalculationSph = new LocSphCalculation();
            _UnitsOfMeasurement = new UomM();
            _UnitsOfMeasurementNm = new UomNM();
            var uom = input.Uom.ToUpper();
            var method = input.Method.ToUpper();
            double rawDist;

            switch (uom)
            {
                case "KM":

                    switch (method)
                    {
                        case "FLAT":
                            return await _InitiateCalculation.Calculate(_CalculationFla, input);
                        default:
                            return await _InitiateCalculation.Calculate(_CalculationSph, input);

                    }
                case "NM":

                    switch (method)
                    {
                        case "FLAT":
                            rawDist = await _InitiateCalculation.Calculate(_CalculationFla, input);
                            return _ConvertToUom.Convert(_UnitsOfMeasurementNm, rawDist);
                        default:
                            rawDist = await _InitiateCalculation.Calculate(_CalculationSph, input);
                            return _ConvertToUom.Convert(_UnitsOfMeasurementNm, rawDist);
                    }
                case "M":

                    switch (method)
                    {
                        case "FLAT":
                            rawDist = await _InitiateCalculation.Calculate(_CalculationFla, input);
                            return _ConvertToUom.Convert(_UnitsOfMeasurement, rawDist);
                        default:
                            rawDist = await _InitiateCalculation.Calculate(_CalculationSph, input);
                            return _ConvertToUom.Convert(_UnitsOfMeasurement, rawDist);
                    }
                default:
                    switch (method)
                    {
                        case "FLAT":
                            return await _InitiateCalculation.Calculate(_CalculationFla, input);
                        default:
                            return await _InitiateCalculation.Calculate(_CalculationSph, input);
                    }
            }
        }

    }
}