using System;
class Demo
{
    string name,address;
    int roll;

    Demo (string n,int r)
    {
        name = n;
        roll = r;
    }
    Demo (string n, string a,int r)
    {
        
        name = n;
        address = a;
        roll = r;
        
    }

    void display()
    {
        Console.WriteLine($"The name is {name}, roll is {roll} and address {address}");

    }

    static void Main (string[] args)
    {
        Demo d = new Demo("Ram",123);
        d.display();
    }

}