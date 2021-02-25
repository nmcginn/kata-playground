using NUnit.Framework;
using System;
using kata_playground;

public class ExampleTests
{
    [Test]
    public void Ex1()
    {
        var directions = new[]
        {
            "Head EAST",
            "Take the 2nd LEFT",
            "Take the NEXT LEFT",
            "Take the NEXT LEFT",
            "Go straight on for 1.5km",
            "Take the NEXT RIGHT",
            "Take the 2nd RIGHT",
            "Go straight on for 1.7km",
            "Turn around!",
            "Take the NEXT LEFT",
            "Go straight on for 1.0km",
            "You have reached your destination!"
        };
        Assert.AreEqual(new Point(0, 0), Kata.SatNav(directions));
    }

    [Test]
    public void Ex2()
    {
        var directions = new[]
        {
            "Head NORTH",
            "Take the 2nd LEFT",
            "Take the 2nd LEFT",
            "Take the NEXT LEFT",
            "Go straight on for 3.5km",
            "Take the NEXT RIGHT",
            "Go straight on for 2.3km",
            "Take the NEXT RIGHT",
            "Take the NEXT RIGHT",
            "Take the NEXT LEFT",
            "Take the NEXT RIGHT",
            "Go straight on for 900m",
            "You have reached your destination!"
        };
        Assert.AreEqual(new Point(0, -1), Kata.SatNav(directions));
    }
}