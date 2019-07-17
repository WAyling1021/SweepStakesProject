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

        //Constructor 

        //Member methods 
        public static void ContestestantInfo()
        {
            Console.WriteLine("What is your first name?:");
            string name = Console.ReadLine();

            Console.WriteLine("What is your last name?:");
            string lastName = Console.ReadLine();

            Console.WriteLine("What is your email address?:");
            string emailAddress = Console.ReadLine();

            Console.WriteLine("What is your registration number?:");
            string registrationNumber = Console.ReadLine();

            string fullName = name + " " + lastName;
            Console.WriteLine($"Your full name is: {fullName}");
            Console.ReadLine();


        }
    }
}
