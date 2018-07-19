using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.QuackBehaviors;
using StrategyPattern.FlyBehaviors;

namespace StrategyPattern.Ducks
{
    public class CityDuck : Duck
    {
        public CityDuck()
        {
            _quackBehavior = new SimpleQuack();
            _flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I am a city duck");
        }

    }
}
