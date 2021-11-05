using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ListasEx {
    class Program {
        static void Main(string[] args) {
            List<Employee> emp = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++) {
                Console.Write($"Employee: #{i + 1}");
                Console.Write("\nID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                emp.Add(new Employee(id, name, salary));
            }
            Console.Write("Enter the employee id that will have salary increase: ");
            int id1 = int.Parse(Console.ReadLine());

            Employee e = emp.Find(z => z.Id == id1);
            if (e != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e.RaiseSalary(percentage);
            }
            else {
                Console.WriteLine("This ID does not exist!");
            }


            Console.WriteLine();
            foreach (Employee n in emp) {
                Console.WriteLine(n);
            }
        }
    }
}
