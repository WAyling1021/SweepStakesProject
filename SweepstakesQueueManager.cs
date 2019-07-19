using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesContest
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        //Queue mem variable 
        Queue<Sweepstakes> sweepstakesQueue;
        public Sweepstakes GetSweepstakes()
        {
            return sweepstakesQueue.Dequeue();
        }

        public void insertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesQueue.Enqueue(sweepstakes);
        }
    }
}
