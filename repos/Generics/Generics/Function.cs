using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Function
    {
        static void Main(string[] args)
        {
            Program<int> m = new Program<int>(10);
            int intValue = m.GetValue();
            Console.WriteLine($"Value of intValue: {intValue}");

            Program<string> n = new Program<string>("App's Interface");
            string stringValue = n.GetValue();
            Console.WriteLine($"Value of stringValue: {stringValue}");
        }
    }
}