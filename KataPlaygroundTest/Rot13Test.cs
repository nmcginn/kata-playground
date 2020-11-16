using kata_playground;
using NUnit.Framework;
using System;

[TestFixture]
public class SolutionTest
{
    [Test, Description("test")]
    public void testTest()
    {
        Assert.AreEqual("grfg", Kata.Rot13("test"), String.Format("Input: test, Expected Output: grfg, Actual Output: {0}", Kata.Rot13("test")));
    }

    [Test, Description("Test")]
    public void TestTest()
    {
        Assert.AreEqual("Grfg", Kata.Rot13("Test"), String.Format("Input: Test, Expected Output: Grfg, Actual Output: {0}", Kata.Rot13("Test")));
    }

    [Test, Description("MyTest")]
    public void MyTest()
    {
        Assert.AreEqual("yzabc", Kata.Rot13("lmnop"));
    }
}