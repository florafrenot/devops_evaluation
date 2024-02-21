using System;
using EvaluationSampleCode;

namespace PratiqueWithCodeGroupe2.UnitTests;

[TestClass]
public class HtmlFormatHelperTests
{
    // Initialize
    private HtmlFormatHelper _htmlFormatHelper;

    [TestInitialize]
    public void Init()
    {
        _htmlFormatHelper = new HtmlFormatHelper();
    }

    [TestMethod]
    public void GetStrongFormat_ReturnsCorrectFormatWithContent()
    {
        string content = "Il s'agit d'un test.";
        string expectedFormat = "<strong>Il s'agit d'un test.</strong>";

        string result = _htmlFormatHelper.GetStrongFormat(content);

        Assert.AreEqual(expectedFormat, result);
    }

    [TestMethod]
    public void GetItalicFormat_ReturnsCorrectFormatWithContent()
    {
        string content = "Texte en Italic.";
        string expectedFormat = "<i>Texte en Italic.</i>";

        string result = _htmlFormatHelper.GetItalicFormat(content);

        Assert.AreEqual(expectedFormat, result);
    }


    [TestMethod]
    public void GetFormattedListElements_ReturnsCorrectFormat()
    {
        List<string> contents = new List<string> { "Choix 1", "Choix 2", "Choix 3" };
        string expectedFormat = "<ul><li>Choix 1</li><li>Choix 2</li><li>Choix 3</li></ul>";

        string result = _htmlFormatHelper.GetFormattedListElements(contents);

        Assert.AreEqual(expectedFormat, result);
    }



}

