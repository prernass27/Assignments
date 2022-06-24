using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmployeeName { get; set; }
        public double Salary { get; set; }
        public double HRA { get; set; }
        public double TA { get; set; }
        public double DA { get; set; }
        public double PF { get; set; }
        public double TDS { get; set; }
        public double NetSalary { get; set; }
        public double GrossSalary { get; set; }

        public double CalculateGross()
        {
            if (Salary < 5000)
            {
                HRA = 0.1 * Salary;
                TA = 0.05 * Salary;
                DA = 0.15 * Salary;

            }
            else if (Salary > 5000 && Salary < 10000)
            {
                HRA = 0.15 * Salary;
                TA = 0.10 * Salary;
                DA = 0.2 * Salary;

            }
            else if (Salary > 10000 && Salary < 15000)
            {
                HRA = 0.2 * Salary;
                TA = 0.15 * Salary;
                DA = 0.25 * Salary;

            }
            else if (Salary > 15000 && Salary < 20000)
            {
                HRA = 0.25 * Salary;
                TA = 0.20 * Salary;
                DA = 0.30 * Salary;

            }
            else if (Salary <= 20000)
            {
                HRA = 0.3 * Salary;
                TA = 0.25 * Salary;
                DA = 0.35 * Salary;

            }

            GrossSalary = Salary + HRA + TA + DA;
            return GrossSalary;
        }

        public double CalculateSalary()
        {
            double gross = CalculateGross();
            PF = 0.10 * gross;
            TDS = 0.18 * gross;
            NetSalary = gross - (PF + TDS);
            return NetSalary;
        }
        public void DisplayDetails()
        {
            double net = CalculateSalary();
            Console.WriteLine($@"
                                 Employee Id : {EmpNo}
                                 Name : {EmployeeName} 
                                 Employee Salary: {net}
                               ");
        }
    }
}