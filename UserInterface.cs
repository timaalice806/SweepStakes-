using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
       public static string GetUserInput(string output)
       {
            Console.WriteLine(output);
            return Console.ReadLine();
       }
       public static string GetManagerInput(string output)
       {
            Console.WriteLine("Entername of sweepstakes");
            return Console.ReadLine();
        }
    }
}
