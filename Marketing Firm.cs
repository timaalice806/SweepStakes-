using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Marketing_Firm 
    {
        //MEMBER VARIABLES (MARKETING FIRM HAS A..)

        ISweepstakes_Manager _manager;

       public Marketing_Firm(ISweepstakes_Manager _manager) //CONSTRUCTOR INJECTION//
       {
            this._manager = _manager;
       }
       public void CreateSweepstake()
       {
            Sweepstakes sweepstakes = new Sweepstakes(UserInterface.GetManagerInput();
            
            _manager.InsertSweepstakes(sweepstakes);
       }
    }
}
