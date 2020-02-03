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
    }
}
