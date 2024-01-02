using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ChickenDecorator : PizzaDecorator

    {
        public ChickenDecorator(IPizza pizza)

        : base(pizza) { }


        public override string Bake()
        {
            return base.Bake() + "Chicken";
        }
     
    }    

}
    

