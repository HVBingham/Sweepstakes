using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager:ISweepstakesManager
    {
        Stack<string> sweepstakesStack;
        public SweepstakesStackManager()
        {
            sweepstakesStack = new Stack<string>();
        }

       public void InsertSweepstakes(Sweepstakes sweepstakes)
        {

        }
        public Sweepstakes GetSweepstakes()
        {

        }
    }
}
