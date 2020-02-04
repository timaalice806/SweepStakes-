using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes_StackManager : ISweepstakes_Manager
    {
        //MEMBER VARIABLES (STACK MANAGER HAS A..)
        Stack<Sweepstakes> stack = new Stack<Sweepstakes>();

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            Stack<Sweepstakes> stack = new Stack<Sweepstakes>();

            stack.Push(sweepstakes);
            UserInterface.GetUserInput("Enter name of sweepstakes");
        }
        public Sweepstakes GetSweepstakes()
        {
            return stack.Pop();
        }

    }
}
