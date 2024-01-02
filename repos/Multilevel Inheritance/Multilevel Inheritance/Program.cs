using System;
class Animal
{
    public void eat()
    {
        Console.WriteLine("I am eating");

    }

    class Dog : Animal
    {
        public void bark()
        {
            Console.WriteLine("I am barking");
        }


        class BabyDog : Dog
        {
            public void weep()
            {
                Console.WriteLine("I am weeping");
            }

            class Demo
            {
                public static void Main(string[] args)
                {
                    BabyDog d = new BabyDog();
                    d.eat();
                    d.bark();
                    d.weep();
                }
            }
        }
    }
}