using System.Collections.Generic;
using System.Linq;

namespace kata_playground
{
    public partial class Kata
    {
        public static int[] Snail(int[][] array)
        {
            var list = new List<int>();
            if (array.Length == 0 || array[0].Length == 0)
                return list.ToArray();
            if (array.Length == 1 && array[0].Length == 1)
            {
                list.Add(array[0][0]);
                return list.ToArray();
            }

            // add the top row
            list.AddRange(array[0]);

            // traverse the right-hand side
            for (var i = 1; i < array.Length; i++)
            {
                list.Add(array[i][array.Length - 1]);
            }

            //traverse the bottom
            for (var i = array.Length - 2; i >= 0; i--)
            {
                list.Add(array[array.Length - 1][i]);
            }

            // traverse the left-hand side
            for (var i = array.Length - 2; i > 0; i--)
            {
                list.Add(array[i][0]);
            }

            // traverse the remaining center portion
            if (array.Length > 2)
            {
                var innerArray = array.Where((val, idx) => idx != 0 && idx != array.Length - 1).ToArray();
                for (var i = 0; i < innerArray.Length; i++)
                {
                    innerArray[i] = innerArray[i].Skip(1).Take(innerArray[i].Length - 2).ToArray();
                }
                list.AddRange(Snail(innerArray));
            }

            return list.ToArray();
        }
    }
}