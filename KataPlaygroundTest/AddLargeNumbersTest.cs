
using kata_playground;
using NUnit.Framework;
using System;

// TODO: Replace examples and use TDD by writing your own tests

[TestFixture]
public class AddLargeNumberTests
{
    [Test]
    public void BasicTest()
    {
        var result = Kata.Add("0", "1");

        Assert.AreEqual("1", result);
    }

    [Test]
    public void MassiveNumberTest()
    {
        var result = Kata.Add("1234567890", "9013245387");

        Assert.AreEqual("10247813277", result);
    }

    [Test]
    public void UnevenNumberTest()
    {
        var result = Kata.Add("1", "12345");

        Assert.AreEqual("12346", result);
    }

    [Test]
    public void FullCarryTest()
    {
        var result = Kata.Add("1", "999");

        Assert.AreEqual("1000", result);
    }
}
