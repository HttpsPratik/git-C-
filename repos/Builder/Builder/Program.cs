using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder;

    class Program
    {
        static void Main()
        {
            
                IMeal builder = new MealDirector();

                builder.AddMomo("Tasty Momo");
                builder.AddRice("Fried Rice");
                builder.AddTea("Masala Tea");

            Meal meal = builder.Build();
            
        Console.WriteLine($"Momo:{meal.Momo}, Rice:{meal.Rice}, Tea:{meal.Tea} ");
        }

    }

