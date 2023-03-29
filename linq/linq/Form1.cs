using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace linq
{
    public partial class Form1 : Form
    {
        List<People> peoples = new List<People>();
        List<Department> department = new List<Department>();
        List<Employ> employes = new List<Employ>();

        public Form1()
        {
            InitializeComponent();
            FillList();
            department.Add(new Department("Отдел закупок", "Германия"));
            department.Add(new Department("Отдел продаж", "Испания"));
            department.Add(new Department("Отдел маркетинга", "Испания"));
            employes.Add(new Employ("Иванов", "Отдел закупок"));
            employes.Add(new Employ("Петров", "Отдел закупок"));
            employes.Add(new Employ("Сидоров", "Отдел продаж"));
            employes.Add(new Employ("Лямин", "Отдел продаж"));
            employes.Add(new Employ("Сидаренко", "Отдел маркетинга"));
            employes.Add(new Employ("Кривоносов", "Отдел продаж"));

        }
        void FillList()
        {
            if (File.Exists("info.txt"))
            {
                string[] persons = File.ReadAllLines("info.txt");
                foreach (string person in persons)
                {
                    string[] info = person.Split(' ');
                    People pers = new People(info[0], info[1], info[2], int.Parse(info[3]), double.Parse(info[4]));
                    peoples.Add(pers);
                }
            }
            else
                MessageBox.Show("Файла не существует");
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SortByAge_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            listBox1.Items.Clear();
            var ages = from t in peoples
                       where t.GetAge > 40
                       select t;
            foreach (People t in ages)
            {
                listBox1.Items.Add(t.Info());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void ShowCountryOnI_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            var show_on_i = from empl in employes
                            join depart in department on empl.GetDeprtament equals depart.GetDep
                            select new { Employ = empl.GetName, Department = depart.GetDep, Country = depart.GetReg };
            foreach(var item in show_on_i)
            {
                if (item.Country.StartsWith("И"))
                    listBox2.Items.Add($"{item.Employ}, {item.Department}, {item.Country}");
            }
        }

        private void GroupPeople_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            var group = from dep in department
                        join em in employes on dep.GetDep equals em.GetDeprtament into g
                        select new
                        {
                            Departament = dep.GetDep,
                            Country = dep.GetReg,
                            Employees = g
                        };
            foreach (var item in group)
            {
                listBox2.Items.Add($"{item.Departament}, {item.Country}");
                foreach(var employ in item.Employees)
                {
                    listBox2.Items.Add($"{employ.GetName}");
                }
                listBox2.Items.Add(" ");
            }
            
          
        }
    }
}
