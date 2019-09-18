using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        ISweepstakesManager sweepStakesManager;
        Sweepstakes sweepstakes;
        string sweepstakesName;
        int maxContestants;
        public MarketingFirm(ISweepstakesManager sweepStakesManager)
        {
            this.sweepStakesManager = sweepStakesManager;
            sweepstakes = new Sweepstakes(sweepstakesName, maxContestants);
        }
      
        public void SweepstakesName()
        {
           
            UserInterface.SweepstakesName();
            sweepstakesName = Console.ReadLine();
        }
        public void SetMaxNumberOfContestants()
        {
            
            UserInterface.MaxContestants();
            maxContestants = int.Parse(Console.ReadLine());
        }




    }
}
