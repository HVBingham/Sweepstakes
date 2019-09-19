using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
   public class Contestants
    {
        public string firstName;
        public string lastName;
        public string email;
        public int registrationNumber;
        public Contestants()
        {

        }
        public void GetContestantsInfo()
        {
            UserInterface.GetContestantInfo("Please enter frist name:");
            firstName = Console.ReadLine();
            UserInterface.GetContestantInfo("Please enter last name:");
            lastName = Console.ReadLine();
            UserInterface.GetContestantInfo("Please enter email: ");
            email = Console.ReadLine();
        }
   }
}
