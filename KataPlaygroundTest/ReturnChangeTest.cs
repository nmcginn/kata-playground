using kata_playground;
using NUnit.Framework;

[TestFixture]
public class ReturnChangeTest
{
    [Test]
    public void TestChangeMachine()
    {
        Assert.AreEqual("Dollars: 0, Quarters: 3, Dimes: 0, Nickels: 1, Pennies: 2", Kata.Change(18, 17.18));
        Assert.AreEqual("Dollars: 2, Quarters: 3, Dimes: 0, Nickels: 1, Pennies: 2", Kata.Change(20, 17.18));
        Assert.AreEqual("Dollars: 3, Quarters: 1, Dimes: 0, Nickels: 1, Pennies: 2", Kata.Change(20.50, 17.18));
    }
}