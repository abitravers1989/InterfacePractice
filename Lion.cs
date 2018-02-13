using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePractice
{

  
    public class Lion: Animal,IMove
    {
        public string Name { get; set; }
        public override void Eat()
        {
            Console.WriteLine("deating lion stuff innit");
        }

        public void Move()
        {
            Console.WriteLine("raaaaar im sleeping go away ");
        }
    }
}
