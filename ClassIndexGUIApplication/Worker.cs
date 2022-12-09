using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIndexGUIApplication
{
    internal class Worker : Person
    {
        public string WorkTitle { get; set; }
        public Worker(string name, int age, string workTitle) : base(name, age)
        {
            WorkTitle = workTitle;
        }
    }
}
