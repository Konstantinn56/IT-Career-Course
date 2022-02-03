using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _04._6
{
    abstract class BaseEmployee
    {
        private string employeeID;
        private string name;
        private string employeeAddress;
        private string employeeDepartment;

        public BaseEmployee(string id , string name , string address , string dp)
        {
            this.EmployeeID = id;
            this.Name = name;
            this.EmployeeAddress = address;
            this.EmployeeDepartment = dp;
        }
        public string EmployeeID
        {
            get { return employeeID; }
            protected set { employeeID = value; }
        }
        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }
        public string EmployeeAddress
        {
            get { return employeeAddress; }
            protected set { name = value; }
        }
        public string EmployeeDepartment
        {
            get { return employeeDepartment; }
            protected set { employeeDepartment = value; }
        }


        public virtual void Show()
        {
            Console.WriteLine($"Im {this.Name} my ID is:{this.EmployeeID} and my address is:{this.EmployeeAddress}");
        }
        abstract public double CalculateSalary(int workingHours);
        public string GetDepartment()
        {
            return this.EmployeeDepartment;
        }
        
    }
}
