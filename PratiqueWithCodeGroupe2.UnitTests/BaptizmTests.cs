using System;
using EvaluationSampleCode;

namespace PratiqueWithCodeGroupe2.UnitTests;

[TestClass]
public class BaptizmTests
{
    [TestMethod]
    public void CanBeBaptizedBy_Priest_ReturnsTrue()
    {
        var priest = new ClergyMember { IsPriest = true };
        var baptizm = new Baptizm(new ClergyMember());

        var result = baptizm.CanBeBaptizedBy(priest);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void CanBeBaptizedBy_Pope_ReturnsTrue()
    {

        var pope = new ClergyMember { IsPope = true };
        var baptizm = new Baptizm(new ClergyMember());

        var result = baptizm.CanBeBaptizedBy(pope);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void CanBeBaptizedBy_NonPriestOrPope_ReturnsFalse()
    {
        var nonPriestOrPope = new ClergyMember();
        var baptizm = new Baptizm(new ClergyMember());

        var result = baptizm.CanBeBaptizedBy(nonPriestOrPope);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void CanBeTeachedBy_DifferentClergyMember_ReturnsFalse()
    {
        var baptizm = new Baptizm(new ClergyMember());
        
        var otherClergyMember = new ClergyMember();

        var result = baptizm.CanBeTeachedBy(otherClergyMember);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void CanBeTeachedBy_SameClergyMember_ReturnsTrue()
    {
        var clergyMember = new ClergyMember();
        var baptizm = new Baptizm(clergyMember);

        var result = baptizm.CanBeTeachedBy(clergyMember);

        Assert.IsTrue(result);
    }



}

