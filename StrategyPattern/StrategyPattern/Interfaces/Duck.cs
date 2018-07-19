using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces;

namespace StrategyPattern
{
    public abstract class Duck
    {
        protected IFlyBehavior _flyBehavior;
        protected IQuackBehavior _quackBehavior;

        public IFlyBehavior FlyBehavior
        {
            set { _flyBehavior = value; }
        }

        public IQuackBehavior QuackBehavior
        {
            set { _quackBehavior = value; }
        }



        public void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            _quackBehavior.Quack();
        }


        public abstract void Display();
    }
}
