using System;

class Demo
{
    static void Main(String[] args)
    {
        int a, sum=0;
        Console.WriteLine("Enter the value of a");
        a = Convert.ToInt32(Console.ReadLine()); 
        for(int i = a; i >= 0; i--)
        {
            sum = sum + i;
            
        }
        Console.WriteLine($"The sum is {sum}");
    }
}