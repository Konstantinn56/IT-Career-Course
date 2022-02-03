using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._6
{
    class ContractEmployee : BaseEmployee
    {
        private string employeeTask;
        public ContractEmployee(string id , string name , string address,string employeeTask, string department) : base(id , name , address , department)
        {
            this.EmployeeTask = employeeTask;
        }

        public string EmployeeTask
        {
            get { return employeeTask; }
            protected set { employeeTask = value; }
        }
        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 20;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Task:{this.EmployeeTask}");
        }
    }
}
