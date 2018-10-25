using System;

namespace Payroll_System
{
    class Employee
    {
        /// <summary>
        /// Instance variables for the employee
        /// Taking double to store point data.
        /// </summary>
        public string Name { get; set; }
        public double GrossSalary { get; set; }
        public double TaxRate { get; set; }

        /// <summary>
        /// Constructor for the Class.
        /// </summary>
        public Employee()
        {
            Console.WriteLine("\n Employee record created.");
        }

        /// <summary>
        /// Method to Calculate Net Salary of the employee.
        /// </summary>
        /// <returns> Net Salary of employee.</returns>
        public double CalcNet()
        {
            //calculating amount of tax.
            double taxAmount = GrossSalary * TaxRate / 100;

            //reducing tax amount from gross salary to calculate net salary
            double netSalary =  GrossSalary-taxAmount;

            //returning net salary
            return netSalary;
        }

    }
}
