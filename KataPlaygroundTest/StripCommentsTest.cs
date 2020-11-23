using kata_playground;
using NUnit.Framework;

public class StripCommentsTest
{
    [Test]
    public void StripComments()
    {
        Assert.AreEqual(
                "apples, pears\ngrapes\nbananas",
                Kata.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" }));

        Assert.AreEqual("a\nc\nd", Kata.StripComments("a #b\nc\nd $e f g", new string[] { "#", "$" }));
    }
}