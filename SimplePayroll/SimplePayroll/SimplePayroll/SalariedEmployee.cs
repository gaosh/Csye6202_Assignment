using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePayroll
{
    class SalariedEmployee : Employee
    {
        public SalariedEmployee(string name,string ssn) : base(name,ssn){
            type = "SE";
        }
       

        public override double CalculateSalary()
        {
            
            return Salary;
        }
    }
}
