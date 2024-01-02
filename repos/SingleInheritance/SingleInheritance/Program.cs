using System;
class Animal
{
    public void eat()
    {
        Console.WriteLine("I am eating");

    }

    class Dog:Animal
    {
        public void bark()
        {
            Console.WriteLine("I am barking");
        }
    }

        class Demo
        {
            public static void Main (string[] args)
            {
                Dog d=new Dog();
                d.eat();
                d.bark();
            }
        }
}