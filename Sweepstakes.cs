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
        int contestantWinner;
       
        //Constructor 

        //Member methods 
        public void RegisterContestant(Contestant contestant)
        {
            //Adding contestant to the dictionary 
            //Also giving the contestant a registration #
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
            //This logic will allow a random # to be generated
            //Also will return a number from the dictionary 
            int randomNumber = rng.Next(0, dictionary.Count);
            return registerNumber;
        }
        public Sweepstakes(string name)
        {

        }
        public int PickWinner()
        {
            //This logic will also allow a random # to be generated
            //Also will return a number from the dictionary 
            string winner;
            int randomWinner = rng.Next(0, dictionary.Count);
            return contestantWinner; 
        }

    }
}
