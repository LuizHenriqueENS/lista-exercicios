using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ListasEx {
    class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public Employee() {
        }

        public void RaiseSalary(double percentage) {
            Salary += Salary * (percentage / 100);
        }
        
        override
        public string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append(Id + ", ");
            sb.Append(Name + ", ");
            sb.Append(Salary.ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
