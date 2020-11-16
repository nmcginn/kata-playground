using kata_playground;
using NUnit.Framework;

[TestFixture]
public class DigitalRootTest
{
    private Number num;

    [SetUp]
    public void SetUp()
    {
        num = new Number();
    }

    [TearDown]
    public void TearDown()
    {
        num = null;
    }

    [Test]
    public void Tests()
    {
        Assert.AreEqual(7, num.DigitalRoot(16));
        Assert.AreEqual(6, num.DigitalRoot(456));
    }
}