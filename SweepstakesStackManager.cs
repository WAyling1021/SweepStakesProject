using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesContest
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        // stack mem variable
        Stack<Sweepstakes> sweepstakesStack;
        public Sweepstakes GetSweepstakes()
        {
            return sweepstakesStack.Pop();
        }

        public void insertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesStack.Push(sweepstakes); 
        }

     
    }
}
