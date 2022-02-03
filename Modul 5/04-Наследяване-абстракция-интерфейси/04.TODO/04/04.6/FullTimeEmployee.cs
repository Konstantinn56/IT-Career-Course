using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._6
{
    class FullTimeEmployee : BaseEmployee
    {
        private string employeePosition;

        ////////////////////////////////////////////////////////////////////////////////////////////////
        public FullTimeEmployee(string id, string name, string address, string position, string department) : base(id, name, address, department)
        {
            this.EmployeePosition = position;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        public string EmployeePosition
        {
            get { return employeePosition; }
            protected set { employeePosition = value; }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////

        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 10.80;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"My position is:{this.EmployeePosition}");
            Console.WriteLine($"My department is:{this.EmployeeDepartment}");
        }
    }
}
