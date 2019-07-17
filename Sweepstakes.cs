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
        public Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        Random random;
        Contestant contestant;
       


        //Constructor 

        //Member methods 
        public void RegisterContestant(Contestant contestant)
        {

        }
        public void PrintContestantInfo(Contestant contestant)
        {

        }
        public Sweepstakes(string name)
        {

        }
        public void PickWinner(Random Winner)
        {
            int RandomChoosenWinner(int min, int max);
            Random random = new Random();
            return random.Next(); 
        }
       
       

       
    }
}
