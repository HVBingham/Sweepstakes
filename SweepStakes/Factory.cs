using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Factory
    {
        public ISweepstakesManager ChooseManagerType(string input)
        {
           
            switch (input)
            {
                case "stack":
                    return new SweepstakesStackManager();
                case "queue":
                    return new SweepstakesQueueManager();
                default:
                    Console.WriteLine("Not a valid selection. Please try again.");
                    return ChooseManagerType(input);
                    
            }
        }







    }
}
