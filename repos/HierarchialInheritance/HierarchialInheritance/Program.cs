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


        class Cat : Animal
        {
            public void meow()
            {
                Console.WriteLine("I am meowing");
            }

            class Demo
            {
                public static void Main(string[] args)
                {
                    Cat d = new Cat();
                    d.eat();
                    d.bark(); // throws error
                    d.meow();
                }
            }
        }
    }
}