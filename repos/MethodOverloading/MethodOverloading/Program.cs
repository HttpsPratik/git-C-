using System;
class Demo
{
    int Sum (int x, int y )
    {
        return x + y;
    }
    int Sum (int x, int y, int z)
    {
        return x + y + z;
    }
    int Sum (int x,int y,int z,int a)
    {
        return a + x+y+z;
    }

    static void Main (string[] args)
    {
        Demo d=new Demo();
        Console.WriteLine(d.Sum(2, 4));
        Console.WriteLine(d.Sum(3, 5, 6));
    }
}