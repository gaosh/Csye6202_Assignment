using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePayroll
{
    class HourlyEmployees : Employee
    {
        public double WorkedHours { get; }
        
        public double HourlyWage { get; set; }

        public HourlyEmployees(string name,string ssn, double wh):base(name,ssn){
            this.WorkedHours = wh;
            type = "HE";
        }

        public override double CalculateSalary()
        {
            Salary = WorkedHours * HourlyWage;
            return Salary;
        }
    }
}
