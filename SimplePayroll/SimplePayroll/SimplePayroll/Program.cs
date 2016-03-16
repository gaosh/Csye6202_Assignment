using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePayroll
{
    public class Program
    {
        static void Main(string[] args)
        {
            string type;
            string sentienl;

            List<Employee> EL = new List<Employee>();

            Employee e;

            Console.WriteLine("Do nothing to add an Employee/'Q' to Quit/'P' to Print");
            sentienl = Console.ReadLine();

            while (!SentienlCheck(sentienl))
            {
                if (!PrinterCheck(sentienl))
                { 
                Console.WriteLine("Add an Employee");
                Console.WriteLine("Input Employee Type");
                type = Console.ReadLine();
                e = EmployeeGenrator(type);
                if (e == null)
                {
                    Console.WriteLine("Please try again");
                }
                EL.Add(e);
                }

                if (PrinterCheck(sentienl))
                {
                    foreach (Employee em in EL)
                    {
                        Printer(em);
                        Console.WriteLine();

                    }
                }


                Console.WriteLine("Do nothing to add another Employee/'Q' to Quit/'P' to Print");
                sentienl = Console.ReadLine();
            }

         
        }
        public static Boolean SentienlCheck(string s)
        {
            if(s == "Q")
            {
                return true;
            }
            return false;
        }

        public static Boolean PrinterCheck(string p)
        {
            if(p == "P")
            {
                return true;
            }
            return false;
        }

        public static Boolean TypeCheck(string t)
        {
            switch(t)
            {
                case "CE": return true;
                case "HE": return true;
                case "SE": return true;
                case "SBCE": return true;
                default: Console.WriteLine("Wrong Type"); break;
            }
            return false;
        }

        public static Boolean SSNCheck(string s)
        {
            if (s.Length == 11)
            {
                if (s[4] == '-' && s[8] == '-')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            Console.WriteLine("Wrong SSN");
            return false;
        }

        public static Boolean NameCheck(string n)
        {
            Boolean b = true;

            if(n == null)
            {
                return false;
            }

            char[] chars = n.ToCharArray();
            foreach(char c in chars)
            {
                if(c>64 && c < 91) { }
                else if(c>96 && c < 123) { }
                else
                {
                    b = false;
                    break;
                }
            }
            return b;
        }

        public static Boolean NumberCheck(string gs)
        {
            Boolean b = true;

            if (gs == null)
            {
                return false;
            }

            char[] chars = gs.ToCharArray();
            foreach (char c in chars)
            {
                if (c > 47 && c < 58) { }
                else if (c == 46) { }
                else
                {
                    b = false;
                    break;
                }
            }
            return b;
        }

        public static Employee EmployeeGenrator(string t)
        {
            string name;
            string ssn;
            string GS;
            string WH;
            double gs = 0;
            double wh = 0;

            if (TypeCheck(t) == false)
            {
                return null;
            }
            if(t == "CE")
            {
                Console.WriteLine("Input Empoyee Name");


                name = Console.ReadLine();

                if (!NameCheck(name))
                {
                    Console.WriteLine("Wrong Name");
                    return null;

                }

                Console.WriteLine("Input Employee SSN");

                ssn = Console.ReadLine();

                if (!SSNCheck(ssn))
                {
                    return null;
                }

                Console.WriteLine("Input Employee Gross Sales");
                GS = Console.ReadLine();
                if (!NumberCheck(GS))
                {
                    return null;
                }
                gs = Convert.ToDouble(GS);

                CommissionEmployees e = new CommissionEmployees(name, ssn, gs);

                e.CommissionRate = 0.6;

                return e;

            }
            else if(t == "HE")
            {
                Console.WriteLine("Input Empoyee Name");


                name = Console.ReadLine();

                if (!NameCheck(name))
                {
                    Console.WriteLine("Wrong Name");
                    return null;

                }

                Console.WriteLine("Input Employee SSN");

                ssn = Console.ReadLine();

                if (!SSNCheck(ssn))
                {
                    return null;
                }

                Console.WriteLine("Input Employee Working Hours");
                WH = Console.ReadLine();
                if (!NumberCheck(WH))
                {
                    return null;
                }
                wh = Convert.ToDouble(WH);

                HourlyEmployees e = new HourlyEmployees(name, ssn, wh);

                e.HourlyWage = 16.5;

                return e;
            }
            else if(t == "SE")
            {
                Console.WriteLine("Input Empoyee Name");


                name = Console.ReadLine();

                if (!NameCheck(name))
                {
                    Console.WriteLine("Wrong Name");
                    return null;
                    
                }

                Console.WriteLine("Input Employee SSN");

                ssn = Console.ReadLine();

                if (!SSNCheck(ssn))
                {
                    return null;
                }

                SalariedEmployee e = new SalariedEmployee(name,ssn);
                e.Salary = 800.0;
                return e;
            }
            else if(t == "SBCE")
            {
                Console.WriteLine("Input Empoyee Name");


                name = Console.ReadLine();

                if (!NameCheck(name))
                {
                    Console.WriteLine("Wrong Name");
                    return null;

                }

                Console.WriteLine("Input Employee SSN");

                ssn = Console.ReadLine();

                if (!SSNCheck(ssn))
                {
                    return null;
                }

                Console.WriteLine("Input Employee Gross Sales");
                GS = Console.ReadLine();
                if (!NumberCheck(GS))
                {
                    return null;
                }
                gs = Convert.ToDouble(GS);

                SalaryBasedCE e = new SalaryBasedCE(name, ssn, gs);

                e.CommissionRate = 0.6;
                e.BaseSalary = 300;

                return e;
            }
            return null;
        }

        public static void Printer(Employee e)
        {
        
            if(e.type == "SE")
            {
                SalariedEmployee se = (SalariedEmployee)e;
                Console.WriteLine("Salary Employee: {0}", se.Name);
                Console.WriteLine("Social Security Number: {0}", se.SSN);
                Console.WriteLine("Weekly Salary: {0}", se.Salary);
                Console.WriteLine("Earned: {0}", se.CalculateSalary());
            }
            else if(e.type == "HE")
            {
                HourlyEmployees he = (HourlyEmployees)e;
                Console.WriteLine("Hourly Employee: {0}", he.Name);
                Console.WriteLine("Social Security Number: {0}", he.SSN);
                Console.WriteLine("Hourly wage: {0}; Hours worked: {1}",he.HourlyWage,he.WorkedHours);
                Console.WriteLine("Earned: {0}", he.CalculateSalary());
            }
            else if(e.type == "CE")
            {
                CommissionEmployees ce = (CommissionEmployees)e;
                Console.WriteLine("Commission Employees: {0}", ce.Name);
                Console.WriteLine("Social Security Number: {0}", ce.SSN);
                Console.WriteLine("Gross Sale: {0}", ce.GrossSales);
                Console.WriteLine("Commission Rate: {0}", ce.CommissionRate);
                Console.WriteLine("Earned: {0}", ce.CalculateSalary());
            }
            else if(e.type == "SBCE")
            {
                SalaryBasedCE sbce = (SalaryBasedCE)e;
                Console.WriteLine("Commission Employees: {0}", sbce.Name);
                Console.WriteLine("Social Security Number: {0}", sbce.SSN);
                Console.WriteLine("Gross Sale: {0}", sbce.GrossSales);
                Console.WriteLine("Commission Rate: {0}", sbce.CommissionRate);
                Console.WriteLine("Base Salary: {0}", sbce.BaseSalary);
                Console.WriteLine("Earned: {0}", sbce.CalculateSalary());
            }
            else
            {
                Console.WriteLine("Wrong Type");
            }
        }
    }
}
