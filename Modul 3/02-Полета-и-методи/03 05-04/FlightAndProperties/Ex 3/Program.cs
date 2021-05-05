using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,List<Employee>> employees = new Dictionary<string, List<Employee>>();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();
                string name = info[0];
                double salary = double.Parse(info[1]);
                string position = info[2];
                string department = info[3];

                int age = -1;
                Employee employee = new Employee();
                employee.Name = name;
                employee.Salary = salary;
                employee.Postiion = position;
                employee.Department = department;

                if (info.Length == 5)
                {
                    bool isInt = int.TryParse(info[4], out age);
                    if (isInt)
                    {
                        employee.Age = age;
                    }
                    else
                    {
                        employee.Email = info[4];
                    }
                }
                else if(info.Length == 6)
                {
                    employee.Email = info[4];
                    employee.Age = int.Parse(info[5]);
                }

                
                if (!employees.ContainsKey(department))
                {
                    employees.Add(department, new List<Employee>());
                }
                employees[department].Add(employee);
                
            }

            
            double maxSalary = double.MinValue;
            string maxSalaryDepartment = "";
            foreach (var s in employees)
            {
                double currentSalary = 0;
                foreach (var e in s.Value)
                {
                    currentSalary += e.Salary;
                }
                if(currentSalary > maxSalary)
                {
                    maxSalary = currentSalary;
                    maxSalaryDepartment = s.Key;
                }
            }
            Console.WriteLine($"Highest Average Salary: {maxSalaryDepartment}");
            foreach (var e in employees[maxSalaryDepartment].OrderBy(p => p.Name))
            {
                Console.WriteLine(e);
            }
        }
    }
}
