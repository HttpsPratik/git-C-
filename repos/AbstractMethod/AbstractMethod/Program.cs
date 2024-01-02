using System;
abstract class Vehicle
{
    public abstract int getWheel();

}

class Auto : Vehicle
{
    public override int getWheel()
    {
    return 3;
    }
 }

class Demo
{
    public static void Main(string[] args)
    {
        Auto a = new Auto();
        Console.WriteLine(a.getWheel());
    }
}
