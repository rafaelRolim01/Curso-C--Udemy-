using System;
using System.Collections.Generic;
using System.Globalization;

namespace CourseExercicioPropostoLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered?: ");
            int quantidade = int.Parse(Console.ReadLine());

            List < Employee > employee = new List<Employee>();

            for (int i = 1; i <= quantidade; i++)
            {
                Console.WriteLine($"Emplyoee #{i}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employee.Add(new Employee(id, name, salary));
                Console.WriteLine("-------------------------------");
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee em = employee.Find(x => x.Id == searchId);
            if (em != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                em.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Updated list of employees: ");
            foreach (Employee obj in employee)
            {
                Console.WriteLine(obj);
            }

        }

    }
}
