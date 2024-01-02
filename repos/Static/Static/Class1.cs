
namespace Static
{
  class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int firstnumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int secondnumber = int.Parse(Console.ReadLine());

            int result = Math.Add(firstnumber, secondnumber);
            Console.WriteLine($"the addition result is :{result}");

            Console.ReadKey();
        }
    }
}
