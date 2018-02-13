using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePractice
{
    public class Bird: Animal,IMove
    {
        public override void Eat()
        {
            Console.WriteLine("BIRD");

        }

        public void Move()
        {
            Console.WriteLine("THE BIRD IS FLYING");
        }
         
    }
}
