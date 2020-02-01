﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        //MEMBER VARIABLES (CONTESTANT HAS A..)
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        public int RegistrationNumber;
        public Contestant(string FirstName, string LastName, string EmailAddress, int RegistrationNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.EmailAddress = EmailAddress;
            this.RegistrationNumber = RegistrationNumber;
        }
    }
}
