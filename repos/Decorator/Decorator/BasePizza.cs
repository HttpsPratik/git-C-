using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class BasePizza : IPizza
    {
        public string Bake()
        {
            return "Base Pizza";
        }
    }
}
