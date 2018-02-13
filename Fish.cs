using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePractice
{
    public class Fish: Animal,IMove
    {
        public override void Eat()
        {
            Console.WriteLine("FISSSH");
        }

        public void Move()
        {
            Console.WriteLine("fish is swimming");
        }
    }
}
