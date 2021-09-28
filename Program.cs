using System;
using System.Collections.Generic;
using System.Text;

namespace Task6._1
{
    class Program
    {

        public static void Main(String[] args)
        {

            List<Bird> birdList = new List<Bird>();

            Bird bird1 = new Bird();
            bird1.Name = "Feathers";
            Bird bird2 = new Bird();
            bird2.Name = "Polly";


            Penguin penguin1 = new Penguin();
            penguin1.Name = "Happy Feet";
            Penguin penguin2 = new Penguin();
            penguin2.Name = "Gloria";

            Duck duck1 = new Duck();
            duck1.Name = "Daffy";
            duck1.Size = 15;
            duck1.Kind = "Mallard";

            Duck duck2 = new Duck();
            duck2.Name = "Donald";
            duck2.Size = 20;
            duck2.Kind = "Decoy";

            birdList.Add(bird1);
            birdList.Add(bird2);
            birdList.Add(penguin1);
            birdList.Add(penguin2);
            birdList.Add(duck1);
            birdList.Add(duck2);

            Console.WriteLine();

            birdList.Add(new Bird { Name = "Birdy" });

            Console.WriteLine();

            foreach (Bird bird in birdList)
            {

                Console.WriteLine(bird);

            }

            Console.WriteLine();

            List<Duck> duckList = new List<Duck>();

            duckList.Add(duck1);
            duckList.Add(duck2);

            IEnumerable<Bird> upcastDucks = duckList;

            List<Bird> birdL = new List<Bird>();

            birdL.Add(bird1);
            birdL.Add(bird2);

            birdL.AddRange(upcastDucks);

            foreach (Bird bird in birdL)
            {

                Console.WriteLine(bird);

            }

            Console.WriteLine();




            // Using the subclasses
            Cat cat1 = new Cat();
            cat1.Greeting();
            Dog dog1 = new Dog();
            dog1.Greeting();
            BigDog bigDog1 = new BigDog();
            bigDog1.Greeting();

            // Using Polymorphism
            Animal animal1 = new Cat();
            animal1.Greeting();
            Animal animal2 = new Dog();
            animal2.Greeting();
            Animal animal3 = new BigDog();
            animal3.Greeting();

            //Animal animal4 = new Animal();
            // Downcast
            Dog dog2 = (Dog)animal2;
            BigDog bigDog2 = (BigDog)animal3;
            Dog dog3 = (Dog)animal3;
            Dog dog4 = (Dog)animal2; //could not cast Dog to Cat both inherit Animal neither Cat nor Dog have parent-child relationship so they don't obey casting.

            dog2.Greeting(dog3);
            dog3.Greeting(dog2);
            dog2.Greeting(bigDog2);
            bigDog2.Greeting(dog2);
            bigDog2.Greeting(bigDog1);
        }

    }
}
