using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace StopList
{
    public class App
    {
        public string Name { get; set; }
        public int TimeWork { get; set; } 

        public App()        
        {}

        public App(string name, int timeWork)
        {
            Name = name;
            TimeWork = timeWork;
        }

    }
}
