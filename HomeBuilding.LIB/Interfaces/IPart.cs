using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBuilding.LIB.Interfaces
{
    interface IPart
    {
        int Sort { get; set; }
        double price { get; set; }
        string Material { get; set; }
        int Count { get; set; }
        string Company { get; set; }

        DateTime DateStart { get; set; }
        DateTime DateEnd { get; set; }

    }
}
