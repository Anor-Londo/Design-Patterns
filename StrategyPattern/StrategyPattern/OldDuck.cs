using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class OldDuck : Duck
    {
        public OldDuck()
        {
            Fly = new FlyWithWings();
            Quack = new LoudQuack();
        }

        public override void Display()
        {
            Console.WriteLine("\n I'm an old duck \n");
        }
    }
}
