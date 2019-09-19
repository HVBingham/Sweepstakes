using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
        public static void GetContestantInfo(string message)
        {
            Console.WriteLine(message);
        }
        public static void SweepstakesName()
        {
            Console.WriteLine( "Please enter Sweepstakes Name:");

        }
       public static void MaxContestants()
        {
            Console.WriteLine("Please enter max number of contestants for Sweepstakes: ");
        }


        public static void MaxAmountReached()
        {
            Console.WriteLine("The Sweepstakes is full. Please Try again next time");
        }

    }
}
