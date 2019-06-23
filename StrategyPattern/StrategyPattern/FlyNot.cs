using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class FlyNot : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("\n I can't fly! \n");
        }
    }
}
