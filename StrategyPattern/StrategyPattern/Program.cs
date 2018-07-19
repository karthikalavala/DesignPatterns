using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Ducks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck cityduck = new CityDuck();
            cityduck.PerformFly();
            cityduck.PerformQuack();


            Duck rubberduck = new RubberDuck();
            rubberduck.PerformFly();
            rubberduck.PerformQuack();
            Console.ReadLine();
        }
    }
}
