using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesContest
{
    public class Factory
    {
        public static ISweepstakesManager chooseRole(string role)
        {
            ISweepstakesManager user = null;
            switch (role)
            {
                case "Stack":
                    user = new Stack();
                    break;
                case "Queue":
                    user = new Queue();
                    break;
                default:
                    Console.WriteLine("What role will you like to choose?");
                    chooseRole(role);
                    break;
            }
            return user;
        }
    }
}
