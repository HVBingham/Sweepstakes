using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factoryManager = new Factory();           
            UserInterface.AskQuestion("Please choose which type of sweepstakes manager you would like. Type either stack or queue.");
            string input = Console.ReadLine().ToLower();
            ISweepstakesManager iManager = factoryManager.ChooseManagerType(input);
            MarketingFirm mikesFirm = new MarketingFirm(iManager);
            


        }
    }
}
