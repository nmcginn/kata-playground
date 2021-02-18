using NUnit.Framework;
using System;
using System.Linq;
using kata_playground;

public class SnailTest
{
    [Test]
    public void SnailTest1()
    {
        int[][] array =
        {
           new []{1, 2, 3},
           new []{4, 5, 6},
           new []{7, 8, 9}
       };
        var r = new[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
        Test(array, r);
    }

    [Test]
    public void SnailTest2()
    {
        int[][] array = {
            new[]{1,2,3,9},
            new[]{4,5,6,4},
            new[]{7,8,9,1},
            new[]{1,2,3,4}
        };
        var r = new[] { 1, 2, 3, 9, 4, 1, 4, 3, 2, 1, 7, 4, 5, 6, 9, 8 };
        Test(array, r);
    }

    public string Int2dToString(int[][] a)
    {
        return $"[{string.Join("\n", a.Select(row => $"[{string.Join(",", row)}]"))}]";
    }

    public void Test(int[][] array, int[] result)
    {
        var actual = Kata.Snail(array);
        var text = $"{Int2dToString(array)}\nshould be sorted to\n[{string.Join(",", result)}]\nbut received:\n[{string.Join(",", actual)}]";
        Console.WriteLine(text);
        Assert.AreEqual(result, actual);
    }
}