using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesContest
{
    class Contestant
    {
        //Member variables 
        public string name;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;

        //Constructor 

        //Member methods 
        public void ContestestantInfo()
        {
            Console.WriteLine("What is your first name?:");
            name = Console.ReadLine();

            Console.WriteLine("What is your last name?:");
            lastName = Console.ReadLine();

            Console.WriteLine("What is your email address?:");
            emailAddress = Console.ReadLine();

            string fullName = name + " " + lastName;
            Console.WriteLine($"Your full name is: {fullName}");
            Console.ReadLine();


        }
    }
}
