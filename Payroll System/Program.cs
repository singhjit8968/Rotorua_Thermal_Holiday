using System;

namespace Payroll_System
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Colors to change text color on console.
            Console.ForegroundColor = ConsoleColor.Blue;

            //System Opening message
            Console.WriteLine("\n\t\t\t\t\tWelcome to Rotorua Thermal Holiday");        
            Console.ForegroundColor = ConsoleColor.Cyan;

            //Module Information message
            Console.WriteLine("\n\tEmployee Payroll System");                          

            Console.ForegroundColor = ConsoleColor.Red;

            //Creating employee from employee Class.
            Employee employee = new Employee();                                 


            //Accepting Information about Employee
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nEnter Name of Employee : ");
            //saving employee name
            employee.Name = Console.ReadLine();

            Console.WriteLine("\nEnter Gross Salary : ");
            //parsing user input to double and storing gross salary
            employee.GrossSalary = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter Tax Percentage : ");
            //parsing user input to double and storing tax percentage
            employee.TaxRate = double.Parse(Console.ReadLine());


            //Showing Employee Data Record is Saved.
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n Employee Data Saved.");

            //Showing Complete Employee Information
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nEmployee Name : \t\t" + employee.Name);
            Console.WriteLine("Employee Gross Salary : \t" + employee.GrossSalary);
            Console.WriteLine("Employee tax Percentage : \t" + employee.TaxRate);
            Console.WriteLine("\nEmployee's Net Salary : \t" + employee.CalcNet());

            //Holding the console.
            Console.Read();         
        }
    }
}
