using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes {
    public class Sweepstakes 
    {
        string name;
        List<Contestants> contestants;
        int maxContestants;
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
            contestants = new List<Contestants>();

        }
        

        public void RegisterContestant(Contestants contestant)
        {
            UserInterface.GetContestantInfo(contestant);
            contestant.RegistrationNumber = GenterateRegistrationNumber();


        }
        
        private int GenterateRegistrationNumber()
        {
            Random rnd = new Random();
           int number= rnd.Next(1, maxContestants);
            return number;
        }

        public Contestants PickWinner()
        {


        }
        public void PrintContestantInfo(Contestants contestant)
        {

        }
    }
}
