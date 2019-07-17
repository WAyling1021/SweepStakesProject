using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesContest
{
    class Sweepstakes
    {
        //Member Variables 
        //Dictionary will store my group of objects and sets of keys
        Dictionary<int, Contestant> dictionary = new Dictionary<int, Contestant>();
        Random random;
        Random rng;
        Contestant contestant;
        int registerNumber;
       
        //Constructor 

        //Member methods 
        public void RegisterContestant(Contestant contestant)
        {
            //Adding the specified key and value to the dictionary
            // contestant needs to be assigned a registration number
            // key for new entry shouldn't be 1, but the count of the dictionary (+1?)
            contestant.registrationNumber = ResgistrationNumber();
            dictionary.Add(contestant.registrationNumber, contestant);

        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("The name of the contestant is:" + contestant.name);
            Console.WriteLine("The name of the contestant is:" + contestant.lastName);
            Console.WriteLine("The name of the contestant is:" + contestant.emailAddress);
            Console.WriteLine("The name of the contestant is:" + contestant.registrationNumber);

        }
        public int ResgistrationNumber()
        {
            int randomNumber = rng.Next(0, dictionary.Count);
            return registerNumber;
        }
        public Sweepstakes(string name)
        {

        }
        public void PickWinner(Random Winner)
        {
            string winner;


            Console.WriteLine("");

        }
       
       

       
    }
}
