using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company
{
    public class Company
    {
        private string name;
        private string city;
        private List<Employee> employees;

        public Company(string name, string city)
        {
            this.Name = name;
            this.City = city;
            this.Employees = new List<Employee>();
        }

        /////////////////////////////////////////////////////////////////////////////////////////

        public string Name
        {
            get { return name; }
            private set
            {
                if (value.Length > 2)
                {
                    name = value;
                }
                else
                    throw new ArgumentException("Invalid company name");
            }
        }
        public string City
        {
            get { return city; }
            private set
            {
                if (value.Length > 4 && value[0].ToString().Equals(value[0].ToString().ToUpper()))
                {
                    city = value;
                }
                else
                    throw new ArgumentException("Invalid city");
            }
        }
        public List<Employee> Employees
        {
            get { return employees; }
            private set { employees = value; }
        }
        /////////////////////////////////////////////////////////////////////////////////////////

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Company {this.Name} from {this.City} has the following employees:");
            foreach (var e in employees)
            {
                sb.AppendLine($"--->Employee: {e.FirstName}  {e.LastName} with id: {e.Id}  and salary: {e.Salary:f2}");
            }
            return sb.ToString();
        }

        /////////////////////////////////////////////////////////////////////////////////////////

        public void HireEmployee(Employee emp)
        {
            this.Employees.Add(emp);
        }
        public void FireEmployee(string employeeId)
        {
            Employee employeeToRemove = this.Employees.Where(e => e.Id.Equals(employeeId)).FirstOrDefault();
            if (employeeToRemove != null)
            {
                Employees.Remove(employeeToRemove);
            }
                
        }
        public void IncreaseSalaries(double amount)
        {
            foreach (var e in this.Employees)
            {
                e.IncreaseSalaryByAmount(amount);
            }
        }
        public void DecreaseSalaries(double amount)
        {
            foreach (var e in this.Employees)
            {
                if (e.Salary >= amount)
                {
                    e.DecreaseSalaryByAmount(amount);
                }    
            }
        }
        public Employee GetMostHighPaidEmployee()
        {
            Employee employee = this.Employees.OrderByDescending(s => s.Salary).FirstOrDefault();
            return employee;
        }
        public List<Employee> GetTopThreeMostHighPaidEmployees()
        {
            List<Employee> top3Employees = new List<Employee>();
            int count = 0;
            foreach (var e in this.Employees.OrderByDescending(e => e.Salary))
            {
                if (count < 3)
                {
                    top3Employees.Add(e);
                    count++;
                }
                else
                    break;
            }

            return top3Employees;
        }
        public bool CheckEmployeeIsPresent(string employeeId)
        {
            bool isTrue = this.Employees.Any(e => e.Id.Equals(employeeId));
            return isTrue;
        }
        public double GetAverageEmployeeSalary()
        {
            double allSalarysSum = 0.0;
            int counter = 0;
            foreach (var e in this.Employees)
            {
                allSalarysSum += e.Salary;
                counter++;
            }
            return allSalarysSum / counter;
        }
    }
}
