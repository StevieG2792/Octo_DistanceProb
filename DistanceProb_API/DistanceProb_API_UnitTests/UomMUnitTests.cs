using DistanceProb_API.Processor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceProb_API_UnitTests
{
    [TestClass]
    public class UomMUnitTests
    {

        [TestMethod]
        public void CalculateMiles_Values_DefaultReturnType()
        {
            //Arrange
            UomM milesConvert = new UomM();

            //Act
            var response =  milesConvert.ConvertFromKilometers(2177);

            //Assert
            Assert.IsInstanceOfType(response, typeof(double));
        }
        [TestMethod]
        public void CalculateMiles_Values_DefaultReturnValue()
        {
            //Arrange
            UomM milesConvert = new UomM();

            //Act
            var response = milesConvert.ConvertFromKilometers(2817.7339035274103);

            //Assert
            Assert.AreEqual(1750.8553156348269, response);
        }
    }
}


