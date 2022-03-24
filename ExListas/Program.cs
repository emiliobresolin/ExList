using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ExListas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee " + i + ":");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("NAME: ");
                string name = Console.ReadLine();
                Console.Write("SALARY: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
            }
            Console.Write("Enter the employee id that will have salary increase: ");
            int s = int.Parse(Console.ReadLine());
            Employee sr = list.Find(x => x.Id == s);  
            if (sr != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                sr.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine("Updated list of employees: ");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
