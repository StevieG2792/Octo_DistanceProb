using DistanceProb_API.Controllers;
using DistanceProb_API.Interface;
using DistanceProb_API.Models;
using DistanceProb_API.Processor;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceProb_API_UnitTests
{
    [TestClass]
    public class LocSphCalculationUnitTests
    {

        private static DistanceInput _GetDummyDistanceInput() => new DistanceInput()
        {
            Uom = "Default",
            Method = "Default",
            BaseLatitude = 75,
            BaseLongtitude = 90,
            TargetLatitude = 50,
            TargetLongtitude = 80
        };

        [TestMethod()]
        public async Task CalculateSpherical_Values_DefaultReturnType()
        {
            //Arrange
            LocSphCalculation SphCalc = new LocSphCalculation();

            //Act
            var response = await SphCalc.CalculateDistance(_GetDummyDistanceInput());

            //Assert
            Assert.IsInstanceOfType(response, typeof(double));
        }

        [TestMethod()]
        public async Task CalculateSpherical_Values_DefaultReturnValue()
        {
            //Arrange
            LocSphCalculation SphCalc = new LocSphCalculation();

            //Act
            var response = await SphCalc.CalculateDistance(_GetDummyDistanceInput());

            //Assert
            Assert.AreEqual(2817.7339035274103,response);
        }
    }
    
}
