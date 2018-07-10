using HomeBuilding.LIB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBuilding.LIB.Model
{
    namespace HomeBuilding.LIB.Model.Team
    {
    class Worker : IWorker
    {
        public bool IsTeam { get; set; }
        public int Age { get; set; }

        public string FIO { get; set; }

        public double SalaryInHour { get; set; }

        public Speciality Speciality { get; set; }
    }
}
}
