using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesContest
{
    static class Userinterface
    {
        public static string GetFirstName()
        {
            Console.WriteLine("What is your first name?:");
            string name = Console.ReadLine();
            return name;
        }
        public static string GetLastName()
        {
            Console.WriteLine("What is your last name?:");
            string lastName = Console.ReadLine();
            return lastName;
            
        }
        public static string GetEmailAddress()
        {
            Console.WriteLine("What is your email address?:");
            string emailAddress = Console.ReadLine();
            return emailAddress;
            
        }
        public static string GetStackOrQueue()
        {
            Console.WriteLine("Would you like to choose stack or queue");
            string stackOrQueue = Console.ReadLine();
            return stackOrQueue;

        }
    }
}
