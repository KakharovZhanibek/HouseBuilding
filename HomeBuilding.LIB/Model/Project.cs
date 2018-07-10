using GeneratorName;
using HomeBuilding.LIB.Interfaces;
using HomeBuilding.LIB.Model.HomeBuilding.LIB.Model.Home;
using HomeBuilding.LIB.Model.HomeBuilding.LIB.Model.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBuilding.LIB.Model
{
    class Project
    {
        public List<IPart> ListWork = new List<IPart>();
        List<IWorker> Workers = new List<IWorker>();
        TeamLeader leader = new TeamLeader();
        Random rnd = new Random();
        public void CreateWorks()
        {
            int c = rnd.Next(1, 3);
            for (int i = 0; i < c; i++)
            {
                Basement basement = new Basement();
                basement.Company = "Asar";
                basement.Count = 1;
                basement.Material = "-";
                basement.price = rnd.Next();
                ListWork.Add(basement);
            }
            for (int i = 0; i < c*4; i++)
            {
                Walls wall = new Walls();
                wall.Company = ".";
                wall.Count = 1;
                wall.Material = "kirpish";
                wall.SizeX = 10;
                wall.SizeY = 3;
                wall.price = wall.SizeX * wall.SizeY * 15;
                wall.Color = ConsoleColor.Gray;
                ListWork.Add(wall);
            }
            for (int i = 0; i < rnd.Next(2,c*6); i++)
            {
                Window window = new Window();
                window.Company = "--";
                window.Count = 1;
                window.Material = "pistik";
                window.price = rnd.Next(10000, 80000);
                window.SizeX = 1000;
                window.SizeY = 800;
                ListWork.Add(window);
            }
            for(int i=0;i<c*4;i++)
            {
                Door door = new Door();
                door.Company = "IDver";
                door.Count = 1;
                door.Material = "Baobab";
                door.SizeX = 1800;
                door.SizeY = 800;
                door.price = 50000;
                ListWork.Add(door);
            }

            ListWork.Add(new Roof() { Count = 1, price = rnd.Next() });
        }
        public void CreateTeam()
        {
            int count = rnd.Next(5, 10);
            for(int i=0;i<count;i++)
            {
                Worker worker = new Worker();
                worker.FIO = GetUserName();
                worker.Age = rnd.Next(20, 50);
                worker.Speciality = (Speciality)rnd.Next(0, 3);
                worker.SalaryInHour = rnd.Next(800, 3500);
                Workers.Add(worker);
            }
           
            leader.FIO = GetUserName();
            leader.Age = rnd.Next(20, 50);
            leader.SalaryInHour = rnd.Next(800, 3500);
            leader.Brigada = Workers;

            Workers.Add(leader);
        }
        public string GetUserName()
        {
            Generator genName = new Generator();
            return genName.GenerateDefault((Gender)rnd.Next(2))
                .Replace("<center><b><font size=7>", "")
                .Replace("</font></b></center>", "")
                .Replace("\n", "")
                .Substring(1);
        }

        public void StartWork()
        {
            TeamLeader leder = (TeamLeader)Workers.FirstOrDefault(f => f.IsTeam == true);

            ListWork = ListWork.OrderBy(o => o.Sort).ToList();

            for (int i = 0; i < ListWork.Count; i++)
            {
                Worker w = leader[leader.GetWorkerId()];
                IPart p = GetWork();
                if(p!=null)
                {
                    ListWork.IndexOf(p);

                }
            }
        }

        private IPart GetWork()
        {
            ListWork = ListWork
                .OrderBy(o => o.Sort)
                .ToList();

            IPart p = (IPart)ListWork
                .Where(w => w.DateStart == null).Take(1);
            return p;
        }
    }
}
