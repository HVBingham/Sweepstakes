﻿using System;
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
        Contestants winner;
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
                contestants.GetContestantsInfo();
                contestantCounter++;
                contestants.registrationNumber=
                contestantsList.Add(contestantCounter, contestants);
            }
            else
            {
                UserInterface.MaxAmountReached();
            }
        }
        private int Randomize(int min, int max)
        {
            Random rnd = new Random();
            int number = rnd.Next(min, max);
            return number;

        }
        public int CreateRegistrationNumber()
        {

            int randomID;
            int maxRandom = maxContestants * 3;
            randomID = Randomize(maxContestants, maxRandom);
            for

        }
        public Contestants PickWinner()
        {
            int winningNumber;
            winningNumber=RandomizeWinner();
            foreach (KeyValuePair<int, Contestants> pair in contestantsList)
            {
                if (winningNumber == pair.Key)
                {
                   winner= pair.Value;

                }
            }
            return winner;
        }
        public int RandomizeWinner()
        {
            int chosen;
            Random rnd = new Random();
            chosen = rnd.Next(1, contestantCounter);
            return chosen;
        }
        public void PrintContestantInfo(Contestants contestant)
        {
            Console.WriteLine("Name: " +contestant.firstName +" " +contestant.lastName +"/n Email: " +contestant.email +"/n Registration Number: " +contestant.registrationNumber);
        }
    }
}
