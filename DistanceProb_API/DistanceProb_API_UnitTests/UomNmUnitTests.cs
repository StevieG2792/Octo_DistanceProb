using DistanceProb_API.Processor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceProb_API_UnitTests
{
    [TestClass]
    public class UomNmUnitTests
    {

        [TestMethod]
        public void CalculateNauticalMiles_Values_DefaultReturnType()
        {
            //Arrange
            UomNM milesConvert = new UomNM();

            //Act
            var response = milesConvert.ConvertFromKilometers(2177);

            //Assert
            Assert.IsInstanceOfType(response, typeof(double));
        }
        [TestMethod]
        public void CalculateMiles_Values_DefaultReturnValue()
        {
            //Arrange
            UomNM milesConvert = new UomNM();

            //Act
            var response = milesConvert.ConvertFromKilometers(2817.7339035274103);

            //Assert
            Assert.AreEqual(1521.45514534695, response);
        }
    }
}
