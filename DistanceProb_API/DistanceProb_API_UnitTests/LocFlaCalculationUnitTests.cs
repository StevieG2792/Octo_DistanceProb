using DistanceProb_API.Models;
using DistanceProb_API.Processor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceProb_API_UnitTests
{
    [TestClass]
    public class LocFlaCalculationUnitTests
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
                LocFlaCalculation FlaCalc = new LocFlaCalculation();

                //Act
                var response = await FlaCalc.CalculateDistance(_GetDummyDistanceInput());

                //Assert
                Assert.IsInstanceOfType(response, typeof(double));
            }

            [TestMethod()]
            public async Task CalculateSpherical_Values_DefaultReturnValue()
            {
                //Arrange
                LocFlaCalculation FlaCalc = new LocFlaCalculation();

                //Act
                var response = await FlaCalc.CalculateDistance(_GetDummyDistanceInput());

                //Assert
                Assert.AreEqual(2779.873166113968, response);
            }
        
    }
}
