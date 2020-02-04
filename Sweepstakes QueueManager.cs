using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes_QueueManager : ISweepstakes_Manager
    {
        //MEMBER VARIABLES (STACK MANAGER HAS A..)
        Queue<Sweepstakes> queue = new Queue<Sweepstakes>();

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            Queue<Sweepstakes> queue = new Queue<Sweepstakes>();

            queue.Enqueue(sweepstakes);
            UserInterface.GetUserInput("Enter name of sweepstakes");
        }
        public Sweepstakes GetSweepstakes()
        {
            return queue.Dequeue();
        }
    }
}
