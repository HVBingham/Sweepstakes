using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Factory
    {
        public ISweepstakesManager ChooseManagerType()
        {
            UserInterface.AskQuestion("Please choose which type of sweepstakes manager you would like. Type either stack or queue.");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "stack":
                    return new SweepstakesStackManager();
                    break;
                case "queue":
                    return new SweepstakesQueueManager();
                    break;
                default:
                    Console.WriteLine("Not a valid selection. Please try again.");
                    return ChooseManagerType();
                    break;
            }
        }







    }
}
