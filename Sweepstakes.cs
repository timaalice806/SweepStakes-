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
        int incrementer = 0;
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
        public int GenerateRandomNumber(int incrementer)
        {
            Random random = new Random();
            int randomNumber = random.Next(incrementer);
            return randomNumber;
        }
        //MEMBER METHODS (SWEEPSTAKES CAN DO..)
        public void RegisterContestant(Contestant contestant)
        {
            Contestant newContestant = new Contestant();

            newContestant.FirstName = UserInterface.GetUserInput("Enter first name");
            newContestant.LastName = UserInterface.GetUserInput("Enter last name");
            newContestant.EmailAddress = UserInterface.GetUserInput("Enter email address");
            newContestant.RegistrationNumber = incrementer;

            contestants.Add(incrementer, newContestant);
            incrementer++;
        }
        public int PickAWinner ()
        {
            //RANDOMLY CHOOSE WINNER FROM DICTIONARY//
            int randomWinner = GenerateRandomNumber(incrementer);
            return randomWinner;
        }
        public void PrintContestantInfo()
        { 
            Console.WriteLine("Enter the contestant(s) you would like to print: ");
            string input = Console.ReadLine();

            foreach (KeyValuePair<int, Contestant> contestant in contestants)
                if(contestant.Value.FirstName == input)
                {
                    Console.WriteLine($"Contestant information: {contestant.Value}" );
                }
        }
    }
}
