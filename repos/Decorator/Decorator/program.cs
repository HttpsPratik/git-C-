

namespace Decorator
{
class program
    {
        static void Main()
        {
         IPizza pizza= new CheeseDecorator(new BasePizza());
            Console.WriteLine(pizza.Bake() );
        }
    }
}
