using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder;

    public interface IMeal
    {
       void AddMomo (string Momo);
       void AddRice (string Rice);
       void AddTea (string Tea);
        Meal Build();

    }

