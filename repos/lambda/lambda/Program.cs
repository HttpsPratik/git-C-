using System;
delegate int del(int x, int y);
    class Lambdaexpression
{
    static void Main (string[]args)
    {
        del d = (x,y) => x * y;
        int c = d(4,5);
            Console.WriteLine(c);
        Console.ReadLine();
    }
}