using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces;

namespace StrategyPattern.FlyBehaviors
{
    public class FlyWithNitro : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with Nitro boosters!!");
        }
    }
}
