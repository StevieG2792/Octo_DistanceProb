namespace DistanceProb_API_UnitTests;
using DistanceProb_API.Controllers;
using DistanceProb_API.Interface;
using DistanceProb_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Runtime.CompilerServices;

[TestClass]
public class DistanceCalculatorControllerUnitTests
{
    private Mock<ILogger<DistanceController>> _logger;
    private Mock<IConvertToUom> _iConvertToUom = new Mock<IConvertToUom>();
    private Mock<IInitiateCalculation> _iInitiateCalculation = new Mock<IInitiateCalculation>();
    private DistanceController _dC;

    public DistanceCalculatorControllerUnitTests()
    {
        _logger = new Mock<ILogger<DistanceController>>();

        _dC = new DistanceController(_logger.Object, _iInitiateCalculation.Object, _iConvertToUom.Object);

    }

    private static DistanceInput _GetDummyDistanceInput(string uom, string method) => new DistanceInput ()
    {
        Uom = uom,
        Method = method,
        BaseLatitude = It.IsInRange(0,90,Range.Inclusive),
        BaseLongtitude = It.IsInRange(0, 180, Range.Inclusive),
        TargetLatitude = It.IsInRange(0, 90, Range.Inclusive),
        TargetLongtitude = It.IsInRange(0, 180, Range.Inclusive)
    };


    [TestMethod()]
    public async Task GetCoOrdinates_Uom_Method_IsNotHandled_DefaultReturnValue()
    {
        //Arrange
        DistanceController dC = new DistanceController(_logger.Object, _iInitiateCalculation.Object, _iConvertToUom.Object);

        //Act
        var response = await dC.GetCoOrdinates(_GetDummyDistanceInput("default","default"));

        //Assert
        Assert.IsInstanceOfType(response, typeof(double));
    }

    [TestMethod()]
    public async Task GetCoOrdinates_Uom_NotHandled_Method_Flat_DefaultReturnValue()
    {
        //Arrange
        DistanceController dC = new DistanceController(_logger.Object, _iInitiateCalculation.Object, _iConvertToUom.Object);

        //Act
        var response = await dC.GetCoOrdinates(_GetDummyDistanceInput("default", "Flat"));

        //Assert
        Assert.IsInstanceOfType(response, typeof(double));
    }

    [TestMethod()]
    public async Task GetCoOrdinates_Uom_NotHandled_Method_Spherical_DefaultReturnValue()
    {
        //Arrange
        DistanceController dC = new DistanceController(_logger.Object, _iInitiateCalculation.Object, _iConvertToUom.Object);

        //Act
        var response = await dC.GetCoOrdinates(_GetDummyDistanceInput("default", "Spherical"));

        //Assert
        Assert.IsInstanceOfType(response, typeof(double));
    }

    [TestMethod()]
    public async Task GetCoOrdinates_Uom_KM_Method_NotHandled_DefaultReturnValue()
    {
        //Arrange
        DistanceController dC = new DistanceController(_logger.Object, _iInitiateCalculation.Object, _iConvertToUom.Object);

        //Act
        var response = await dC.GetCoOrdinates(_GetDummyDistanceInput("KM", "Default"));

        //Assert
        Assert.IsInstanceOfType(response, typeof(double));
    }

    [TestMethod()]
    public async Task GetCoOrdinates_Uom_KM_Method_Spherical_DefaultReturnValue()
    {
        //Arrange
        DistanceController dC = new DistanceController(_logger.Object, _iInitiateCalculation.Object, _iConvertToUom.Object);

        //Act
        var response = await dC.GetCoOrdinates(_GetDummyDistanceInput("KM", "Spherical"));

        //Assert
        Assert.IsInstanceOfType(response, typeof(double));
    }

    [TestMethod()]
    public async Task GetCoOrdinates_Uom_KM_Method_Flat_DefaultReturnValue()
    {
        //Arrange
        DistanceController dC = new DistanceController(_logger.Object, _iInitiateCalculation.Object, _iConvertToUom.Object);

        //Act
        var response = await dC.GetCoOrdinates(_GetDummyDistanceInput("KM", "Flat"));

        //Assert
        Assert.IsInstanceOfType(response, typeof(double));
    }

    [TestMethod()]
    public async Task GetCoOrdinates_Uom_M_Method_NotHandled_DefaultReturnValue()
    {
        //Arrange
        DistanceController dC = new DistanceController(_logger.Object, _iInitiateCalculation.Object, _iConvertToUom.Object);

        //Act
        var response = await dC.GetCoOrdinates(_GetDummyDistanceInput("M", "Default"));

        //Assert
        Assert.IsInstanceOfType(response, typeof(double));
    }

    [TestMethod()]
    public async Task GetCoOrdinates_Uom_M_Method_Spherical_DefaultReturnValue()
    {
        //Arrange
        DistanceController dC = new DistanceController(_logger.Object, _iInitiateCalculation.Object, _iConvertToUom.Object);

        //Act
        var response = await dC.GetCoOrdinates(_GetDummyDistanceInput("M", "Spherical"));

        //Assert
        Assert.IsInstanceOfType(response, typeof(double));
    }

    [TestMethod()]
    public async Task GetCoOrdinates_Uom_M_Method_Flat_DefaultReturnValue()
    {
        //Arrange
        DistanceController dC = new DistanceController(_logger.Object, _iInitiateCalculation.Object, _iConvertToUom.Object);

        //Act
        var response = await dC.GetCoOrdinates(_GetDummyDistanceInput("M", "Flat"));

        //Assert
        Assert.IsInstanceOfType(response, typeof(double));
    }
    [TestMethod()]
    public async Task GetCoOrdinates_Uom_NM_Method_NotHandled_DefaultReturnValue()
    {
        //Arrange
        DistanceController dC = new DistanceController(_logger.Object, _iInitiateCalculation.Object, _iConvertToUom.Object);

        //Act
        var response = await dC.GetCoOrdinates(_GetDummyDistanceInput("NM", "Default"));

        //Assert
        Assert.IsInstanceOfType(response, typeof(double));
    }

    [TestMethod()]
    public async Task GetCoOrdinates_Uom_NM_Method_Spherical_DefaultReturnValue()
    {
        //Arrange
        DistanceController dC = new DistanceController(_logger.Object, _iInitiateCalculation.Object, _iConvertToUom.Object);

        //Act
        var response = await dC.GetCoOrdinates(_GetDummyDistanceInput("NM", "Spherical"));

        //Assert
        Assert.IsInstanceOfType(response, typeof(double));
    }

    [TestMethod()]
    public async Task GetCoOrdinates_Uom_NM_Method_Flat_DefaultReturnValue()
    {
        //Arrange
        DistanceController dC = new DistanceController(_logger.Object, _iInitiateCalculation.Object, _iConvertToUom.Object);

        //Act
        var response = await dC.GetCoOrdinates(_GetDummyDistanceInput("NM", "Flat"));

        //Assert
        Assert.IsInstanceOfType(response, typeof(double));
    }


}
