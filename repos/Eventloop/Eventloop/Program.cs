namespace Eventloop
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Event loop started");

            for (int i= 0; i < 4 ; i++)
            {
                Console.WriteLine($"Happy New year {i + 1 }");
                System.Threading.Thread.Sleep( 5 );

            }
            Console.WriteLine("Event loop Finished");
        }
    }
}