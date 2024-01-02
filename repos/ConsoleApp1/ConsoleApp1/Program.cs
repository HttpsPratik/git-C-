using System;
class Accountbalance
{
    int accbalance = 1000;
    public int balance
    {
        set
        {
            accbalance = value;
        }

        get
        {
            return accbalance;
        }
    }

    class Demo
    {
        public static void Main (string[] args)
        {
            Accountbalance ac= new Accountbalance();
            ac.balance = 1000;
            Console.WriteLine("your account" + ac.balance);
        }
    }
}