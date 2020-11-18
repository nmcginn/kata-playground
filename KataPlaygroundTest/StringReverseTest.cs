using kata_playground;
using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    public void World()
    {
        Assert.AreEqual("dlrow", Kata.Solution("world"));
    }
}