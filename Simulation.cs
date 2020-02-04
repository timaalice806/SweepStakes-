using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        public ISweepstakes_Manager ChooseManager(string choice)
        {
            ISweepstakes_Manager user = null;
            switch (choice)
            {
                case "Stack":
                    user = new Sweepstakes_StackManager();
                    break;
                case "Queue":
                    user = new Sweepstakes_QueueManager();
                    break;
                default:
                    Console.WriteLine("Not a valid choice");
                    ChooseManager(choice);
                    break;
            }
            return user;
        }
        public void CreateMarketingFirmWithManager()
        {
        }
    }
}
