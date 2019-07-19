using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesContest
{
    public class MarketingFirm 
    {
        
        public ISweepstakesManager managementSystem; 

        //constructor injection 
        public MarketingFirm(ISweepstakesManager managementSystem)
        {
            this.managementSystem = managementSystem;
        }

        
    }
}
