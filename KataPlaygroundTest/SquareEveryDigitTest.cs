using System;
using NUnit.Framework;

using kata_playground;

[TestFixture]
public class SquareEveryDigitTest
{
    [Test]
    public void KataTests()
    {
        Assert.AreEqual(811181, Kata.SquareDigits(9119));
    }
}