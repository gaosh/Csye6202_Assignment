using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePayroll
{
    public abstract class Employee
    {
        public string Name{ get; set; }
        public string SSN {get;set; }
        public double Salary = 0.0;
        public string type;
        public Employee(string name, string ssn)
        {
            this.SSN = ssn;
            this.Name = name;
        }

        public abstract double CalculateSalary();
    }
}
