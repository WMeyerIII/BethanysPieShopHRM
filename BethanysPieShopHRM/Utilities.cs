using BethanysPieShopHRM.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
    internal class Utilities
    {
        #region Practice
        public static void UsingExpressionBodiedSyntax()
        {
            int amounth = 1234;
            int months = 12;
            int bonus = 600;

            int yearlyWageForEmployee = CalculateYearlyWageExpressionBodies(bonus: bonus, monthlyWage: amounth, numberOfMonthsWorked: months);
        }

        public static int CalculateYearlyWageExpressionBodies(int monthlyWage, int numberOfMonthsWorked, int bonus) => monthlyWage * numberOfMonthsWorked + bonus;
        public static void UsingNamedArguments()
        {
            int amount = 1234;
            int months = 12;
            int bonus = 600;

            int yearlyWageForEmployee = CalculateYearlyWageWithNamed(bonus: bonus, monthlyWage: amount, numberOfMonthsWorked: months);
        }
        public static int CalculateYearlyWageWithNamed(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            Console.WriteLine($"The Yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        public static void UsingOptionalParameters()
        {
            int monthlyWage1 = 1234;
            int months1 = 12;

            int yearlyWafeForEmployee1 = CalculateYearlyWageWithOptional(monthlyWage1, months1);
            Console.WriteLine($"Yearly wage for employee 1 (Bethany): {yearlyWafeForEmployee1}");
        }

        public static int CalculateYearlyWageWithOptional(int monthlyWage, int numberOfMonthsWorked, int bonus = 0)
        {
            Console.WriteLine($"The Yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");

            return monthlyWage * numberOfMonthsWorked + bonus;
        }
        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            //Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
            if (numberOfMonthsWorked == 12)
                return monthlyWage * (numberOfMonthsWorked + 1);

            return monthlyWage + numberOfMonthsWorked;
        }
        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            Console.WriteLine($"The Yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");

            return monthlyWage + numberOfMonthsWorked + bonus;
        }
        public static double CalculateYearlyWage(double monthlyWage, double numberOfMonthsWorked, double bonus)
        {
            Console.WriteLine($"The Yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");

            return monthlyWage * numberOfMonthsWorked + bonus;
        }
        #endregion

        #region UIMethods

        private static string directory = @"C:\data\BethanysPieShopHRM\";
        private static string filename = "employees.txt";

        internal static void CheckForExistingEmployeeFile()
        {
            string path = $"{directory}{filename}";
            if (File.Exists(path))
            {
                Console.WriteLine("The file with employee data was found.");
            }
            else
            {
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Directory is ready for saving files.");
                    Console.ResetColor();
                }
            }
        }

        internal static void RegisterEmployee(List<Employee> employees)
        {
            Console.WriteLine("What kind of employee would you like to register?");
            Console.WriteLine("1.Employee\n2.Manager\n3.Store Manager\n4.Researcher\n5.Junior Researcher");
            Console.WriteLine("Your Selection (as a number)");
            string employeeType = Console.ReadLine();

            if (employeeType != "1" && employeeType != "2" && employeeType != "3" && employeeType != "4" && employeeType != "5")
            {
                Console.WriteLine("Invalid selection. Please try again.");
                    return;
            }

            Console.WriteLine("Enter their first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter their last name: ");
            string lastName = Console.ReadLine();

            string email = $"{firstName}{lastName}@snowball.be";

            Console.WriteLine("Enter their birthday: ");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter their hourly rate: ");
            string hourlyRate = Console.ReadLine();
            double rate = double.Parse(hourlyRate);

            Employee employee = null;

            switch (employeeType)
            {
                case "1": 
                    employee = new Employee(firstName, lastName, email, birthDay, rate);
                    break;
                case "2":
                    employee = new Manager(firstName, lastName, email, birthDay, rate);
                    break;
                case "3":
                    employee = new StoreManager(firstName, lastName, email, birthDay, rate);
                    break;
                case "4":
                    employee = new Researcher(firstName, lastName, email, birthDay, rate);
                    break;
                case "5":
                    employee = new JrResearcher(firstName, lastName, email, birthDay, rate);
                    break;
            }

            employees.Add(employee);

            Console.WriteLine("Employee created!\n\n");
        }

        
        internal static void UnregisterEmployees(List<Employee> employees)
        {

        }

        internal static void ViewAllEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                employees[i].DisplayEmployeeDetails();
            }
        }

        internal static void SaveEmployees(List<Employee> employees)
        {

        }

        internal static void LoadEmployees(List<Employee> employees)
        {

        }
        #endregion
    }
}
