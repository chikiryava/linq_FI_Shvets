using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace linq
{
    class People
    {
        private string surname, name, middlename;
        private int age;
        private double weight;
        public People(string surname,string name, string middlename, int age,double weight)
        {
            this.surname = surname;
            this.name = name;
            this.middlename = middlename;
            this.age = age;
            this.weight = weight;
        }
        public int GetAge { get { return age; } set { age = value; } }
        public string Info()
        {
            return $"{surname} {name} {middlename} {age} {weight}";
        }
        
    }
}
