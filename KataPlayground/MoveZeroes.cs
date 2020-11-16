using System.Linq;

namespace kata_playground
{
    public partial class Kata
    {
        public static int[] MoveZeroes(int[] arr)
        {
            var zeroCount = arr.Where(x => x == 0).Count();
            var result = arr.Where(x => x != 0);
            for(var i = 0; i < zeroCount; i++)
                result = result.Append(0);
            return result.ToArray();
        }
    }
}