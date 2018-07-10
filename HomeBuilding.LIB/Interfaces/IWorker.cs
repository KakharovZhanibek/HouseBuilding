using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBuilding.LIB.Interfaces
{
    public enum Speciality
    {
        kam,plot,other
    }
    interface IWorker
    {
        bool IsTeam{get; set;}
        int Age { get; set; }
        Speciality Speciality { get; set; }
        string FIO { get; set; }
        double SalaryInHour { get; set; }

        //double SpeedWork { get; set; }
    }
}
