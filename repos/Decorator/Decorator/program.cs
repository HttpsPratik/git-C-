

namespace Decorator
{

        class Program
        {
            static void Main()
            {
                IPizza pizza = new ChickenDecorator(new CheeseDecorator(new BasePizza()));
                Console.WriteLine(pizza.Bake());
            }
        }
    }

