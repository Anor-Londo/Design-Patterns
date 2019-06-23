using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("\n I'm flying! \n");
        }
    }
}
