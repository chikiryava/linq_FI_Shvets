﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    class Department
    {
        private string name, reg;
        public Department(string name,string reg)
        {
            this.name = name;
            this.reg = reg;
        }
        public string GetName { get { return name; } set { name = value; } }
    }
}
