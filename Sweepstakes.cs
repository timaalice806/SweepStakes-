using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        //MEMBER VARIABLES (SWEEPSTAKES HAS A..)
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        string name;
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
        //CONSTRUCTOR (DEFAULT SWEEPSTAKES)
        public Sweepstakes(string name)
        {
            this.name = name;
        }
        public int GenerateRandomNumber(int maxValue)
        {
            Random random = new Random();
            int randomNumber = random.Next(maxValue);
            return randomNumber;
        }
        //MEMBER METHODS (SWEEPSTAKES CAN DO..)
        public void RegisterContestant(Contestant contestant)
        {

        }
        public Contestant PickWinner ()
        {
            //RANDOMLY CHOOSE WINNER FROM DICTIONARY//
            int randomWinner = GenerateRandomNumber(500);
        }
        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
