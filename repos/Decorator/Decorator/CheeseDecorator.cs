﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza)

        : base(pizza) { }
        

        public override string Bake()
        {
            return base.Bake() + addCheese();
        }
        public string addCheese()
        {
            return "\n Extra Cheese";
        }
        
    }
}
