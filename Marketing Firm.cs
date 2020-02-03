using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Marketing_Firm : ISweepstakes_Manager
    {
       ISweepstakes_Manager
       public Marketing_Firm(ISweepstakesManager manager)
       {

       }
       public void CreateSweepstake()
       {
            Sweepstakes sweepstakes = new Sweepstakes("Generic name");
       }
    }
}
