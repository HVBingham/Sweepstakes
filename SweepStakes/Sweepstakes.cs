using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes {
    public class Sweepstakes 
    {
        string name;
        Dictionary<int, Contestants> contestantsList;
        public int contestantCounter = 0;
        public int maxContestants;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

       public int MaxContestants
        {
            get
            {
                return maxContestants;
            }
            set
            {
                maxContestants = value;
            }
        }

       
        public Sweepstakes(string name,int maxContestants)
        {
            this.name = name;
            this.maxContestants = maxContestants;
            contestantsList = new Dictionary<int, Contestants>();

        }
        

        public void RegisterContestant(Contestants contestants)
        {
            if (contestantCounter < maxContestants)
            {
                contestants = new Contestants();
                contestants.GetInfo(contestants);
                contestantCounter++;
                contestants.RegistrationNumber = contestantCounter;
                contestantsList.Add(contestantCounter, contestants);

            }
            else
            {
                UserInterface.MaxAmountReached();
            }
        }
        
    

        public Contestants PickWinner()
        {


        }
        public void PrintContestantInfo(Contestants contestant)
        {

        }
    }
}
