using System;
interface interface1
{
    void display1();
}

interface interface2
{
    void display2();
}


class Demo : interface1, interface2
{
    public void display1()
    {
        Console.WriteLine("first interface");
    }

    public void display2()
    {
        Console.WriteLine("second interface");
    }
}

class abc
{
    public static void Main(string[] args)
    {
        Demo d=new Demo();
        d.display1();
        d.display2();
    }
}
