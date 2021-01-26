using System.Linq;

namespace kata_playground
{
    public partial class Kata
    {
        public static string Change(double provided, double cost)
        {
            int dollars, quarters, dimes, nickels = 0;

            int remainingChangeInCents = (int)(100 * (provided - cost));
            dollars = remainingChangeInCents / 100;
            remainingChangeInCents -= 100 * dollars;

            quarters = remainingChangeInCents / 25;
            remainingChangeInCents -= 25 * quarters;

            dimes = remainingChangeInCents / 10;
            remainingChangeInCents -= 10 * dimes;

            nickels = remainingChangeInCents / 5;
            remainingChangeInCents -= 5 * nickels;
            
            return $"Dollars: {dollars}, Quarters: {quarters}, Dimes: {dimes}, Nickels: {nickels}, Pennies: {remainingChangeInCents}";
        }
    }
}