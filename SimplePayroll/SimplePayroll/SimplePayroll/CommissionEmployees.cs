using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePayroll
{
    class CommissionEmployees : Employee
    {
        public CommissionEmployees(string name, string ssn, double gs):base(name,ssn){
            GrossSales = gs;
            type = "CE";
            }

        public double GrossSales { get; private set; }
        public double CommissionRate { get; set; }


        public override double CalculateSalary()
        {
            Salary = CommissionRate * GrossSales;
            return Salary;

        }
    }
}
