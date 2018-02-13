using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePractice
{
    public class Car: IMove
    {
        public void Move()
        {
            Console.WriteLine("I am a car who can inheret from the move class even though im not an animal");
        }
    }
}
