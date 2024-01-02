using System;
class Demo
{
    string name;
    int roll;
    Demo(string n,int r)
    {
        name = n;
        roll = r;
        
    }

    void display()
    {
        Console.WriteLine($"The name {name} and roll is {roll} ");
    }

    static void Main (string[] args )
    {
        Demo d = new Demo("Abhaya",1);
        d.display();
    }
}