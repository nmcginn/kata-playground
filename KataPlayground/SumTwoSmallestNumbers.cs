using System.Linq;

namespace kata_playground
{
    public partial class Kata
    {
        public static double sumTwoSmallestNumbers(int[] numbers)
        {
            return numbers.Where(num => num > numbers.Min()).Min() + numbers.Min();
        }
    }
}