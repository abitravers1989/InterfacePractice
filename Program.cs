using System;
using System.Collections.Generic;

namespace InterfacePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion myLion = new Lion();
            myLion.Name = "Steve";
            Bird myBird = new Bird();
            Fish myFish = new Fish();

            List<Animal> myAnimals = new List<Animal>()
                {
                myLion,myBird,myFish
            };

            //myAnimal variable is getting set to every item in the list as it loops through them

            foreach (var myAnimal in myAnimals)
            {
               // Console.WriteLine(myAnimal);
                myAnimal.Eat();
            }

            Car myCar = new Car();


            List<IMove> myMovingObjects = new List<IMove>()
            {
                //this doesn't work if these are instanciated as Animals 
                myLion,myBird,myFish,myCar
            };

            foreach (var myMovingObject in myMovingObjects)
            {
                myMovingObject.Move();
            }

            if(myLion is Animal)
                Console.WriteLine("This is animal");

            if(myCar is Animal)
                Console.WriteLine("is animal");
            //if it is not it will exit 

            //way to check is certain data types are certain type of not 

            Console.ReadKey();
            
        }
    }
}
