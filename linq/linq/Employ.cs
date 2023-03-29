using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    class Employ
    {
        private string name, departament;
        public Employ(string name,string departament)
        {
            this.name = name;
            this.departament = departament;
        }
        public string GetDeprtament { get { return departament; } set { departament = value; } }
        public string GetName { get { return name; } set { name = value; } }
    }
}
