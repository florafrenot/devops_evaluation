using System.ComponentModel.DataAnnotations;
using EvaluationSampleCode;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PratiqueWithCodeGroupe2.UnitTests;


[TestClass]
public class MathOperationsTests
{
    // Initialize
    private MathOperations _mathOperations;

    [TestInitialize]
    public void Init()
    {
        _mathOperations = new MathOperations();
    }

    [TestMethod]

    public void Subtract_WithTwoNumbers_ReturnsCorrectSubstract()
    {
        int a = 5;
        int b = 3;
        int expectedSubstract = 2;

        int result = _mathOperations.Subtract(a, b);

        Assert.AreEqual(expectedSubstract, result);
    }


    [TestMethod]
    [DataRow(0, "Red")]
    [DataRow(7, "Blue")]
    public void GetColorFromOddsNumber_ReturnsCorrectColor(int number, string expectedColor)
    {
        var colorUtility = new MathOperations();
        var result = colorUtility.GetColorFromOddsNumber(number);

        Assert.AreEqual(expectedColor, result);
    }


}
