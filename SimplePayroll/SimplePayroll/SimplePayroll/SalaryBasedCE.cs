using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePayroll
{
    class SalaryBasedCE : CommissionEmployees
    {
        public double BaseSalary { get; set; }

        
        
        public SalaryBasedCE(string name,string ssn, double gs):base(name,ssn,gs){
            type = "SBCE";
        }

        public override double CalculateSalary()
        {
            Salary = BaseSalary + GrossSales * CommissionRate;
            return Salary;
        }

    }
}
