using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class LoudQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("\n QUACK! \n");
        }
    }
}
