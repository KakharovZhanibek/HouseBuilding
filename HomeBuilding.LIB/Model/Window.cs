using HomeBuilding.LIB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBuilding.LIB.Model
{
    namespace HomeBuilding.LIB.Model.Home
    {
        class Window : IPart
        {
            public double SizeX { get; set; }
            public double SizeY { get; set; }



            public ConsoleColor Color { get; set; } = ConsoleColor.White;

            public string Company { get; set; }

            public int Count { get; set; }

            public DateTime DateEnd { get; set; }

            public DateTime DateStart { get; set; }

            public string Material { get; set; }

            public double price { get; set; }

            public int Sort { get; set; } = 3;
        }
    }
}
