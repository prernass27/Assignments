using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.WriteLine("Employee ID: ");
            employee.EmpNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Employee Name: ");
            employee.EmployeeName = Console.ReadLine();

            Console.WriteLine("Salary");
            employee.Salary = double.Parse(Console.ReadLine());

            double grosssalary = employee.CalculateGross();
            Console.WriteLine("Gross Salary :" + grosssalary);

            double netsalary = employee.CalculateSalary();
            Console.WriteLine("NetSalary :" + netsalary);


            employee.DisplayDetails();
        }
    }
}