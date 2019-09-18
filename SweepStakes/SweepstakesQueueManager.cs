using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager:ISweepstakesManager 
    {
        Queue<string> sweepstakesQueue;

        public SweepstakesQueueManager()
        {
            sweepstakesQueue = new Queue<string>();
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {

        }
        public Sweepstakes GetSweepstakes()
        {

        }




    }
}
