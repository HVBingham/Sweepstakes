using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
        public static void GetContestantInfo(Contestants contestants)
        {
            Console.WriteLine("Please Enter First Name: ");
            contestants.FirstName = Console.ReadLine();
            Console.WriteLine("Please Enter Last Name: ");
            contestants.LastName = Console.ReadLine();
            Console.WriteLine("Please Enter Email: ");
            contestants.Email = Console.ReadLine();
            Console.WriteLine("Please Enter Address: ");
            contestants.Address = Console.ReadLine();
        }
        public static void SweepstakesName()
        {
            Console.WriteLine( "Please enter Sweepstakes Name:");

        }
       public static void MaxContestants()
        {
            Console.WriteLine("Please enter max number of contestants for Sweepstakes: ");
        }




    }
}
