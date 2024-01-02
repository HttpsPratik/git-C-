using System;
class A
{
    public void msg()
    {
        Console.WriteLine("hetauda city college");

    }

    class B
    {
        public void msg()
        {
            Console.WriteLine("welcome to HCC");
        }


        class C:A,B
        {
            public void wrong()
            {
                Console.WriteLine("ERror!");
            }

            class Demo
            {
                public static void Main(string[] args)
                {
                    C d = new C();
                    d.msg();
                }
            }
        }
    }
}