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
            Console.WriteLine("Sweepstakes in queue are: ");
            Console.ReadLine();
        }
        public Sweepstakes GetSweepstakes()
        {
            return queue.Dequeue();
            //RETURN A SWEEPSTAKES//
        }

    }
}
