using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.QuackBehaviors;
using StrategyPattern.FlyBehaviors;


namespace StrategyPattern.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            _quackBehavior = new MuteQuack();
            _flyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("I am a mute duck :(");
        }

    }
}
