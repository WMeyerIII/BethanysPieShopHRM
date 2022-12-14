using BethanysPieShopHRM.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
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
        private static string errorlog = "errorlog.txt";

        internal static void CheckForExistingEmployeeFile()
        {
            string path = $"{directory}{filename}";
            if (File.Exists(path))
            {
                Console.WriteLine("The file with employee data was found.");
            }
            else
            {
                if (Directory.Exists(directory))
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
            string path = $"{directory}{filename}";
            StringBuilder sb = new StringBuilder();

            foreach (Employee employee in employees)
            {
                string type = GetEmployeeType(employee);
                sb.Append($"firstName:{employee.FirstName};");
                sb.Append($"lastName:{employee.LastName};");
                sb.Append($"email:{employee.Email};");
                sb.Append($"birthDay:{employee.BirthDay.ToShortDateString()};");
                sb.Append($"hourlyRate:{employee.HourlyRate};");
                sb.Append($"type:{type};");

                sb.Append(Environment.NewLine);
            }

            File.WriteAllText( path, sb.ToString() );
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Employees saved successfully!");
            Console.ResetColor();
        }

        internal static string GetEmployeeType(Employee employee)
        {
            if (employee is Manager)
                return "2";
            else if (employee is StoreManager)
                return "3";
            else if (employee is JrResearcher)
                return "4";
            else if (employee is Researcher)
                return "5";
            else if (employee is Employee)
                return "1";
            return "0";
        }

        internal static void LoadEmployees(List<Employee> employees)
        {
            string path = $"{directory}{filename}";
            string errorpath = $"{directory}{errorlog}";
            try
            {
                if (File.Exists(path))
                {
                    employees.Clear();
                    string[] employeesAsString = File.ReadAllLines(path);

                    for (int i = 0; i < employeesAsString.Length; i++)
                    {
                        string[] employeeSplits = employeesAsString[i].Split(";");
                        string firstName = employeeSplits[0].Substring(employeeSplits[0].IndexOf(":") + 1);
                        string lastName = employeeSplits[1].Substring(employeeSplits[1].IndexOf(":") + 1);
                        string email = employeeSplits[2].Substring(employeeSplits[2].IndexOf(":") + 1);
                        DateTime birthDay = DateTime.Parse(employeeSplits[3].Substring(employeeSplits[3].IndexOf(":") + 1));
                        double hourlyRate = double.Parse(employeeSplits[4].Substring(employeeSplits[4].IndexOf(':') + 1));
                        string employeeType = employeeSplits[5].Substring(employeeSplits[5].IndexOf(":") + 1);

                        Employee employee = null;

                        switch (employeeType)
                        {
                            case "1":
                                employee = new Employee(firstName, lastName, email, birthDay, hourlyRate);
                                break;
                            case "2":
                                employee = new Manager(firstName, lastName, email, birthDay, hourlyRate);
                                break;
                            case "3":
                                employee = new StoreManager(firstName, lastName, email, birthDay, hourlyRate);
                                break;
                            case "4":
                                employee = new Researcher(firstName, lastName, email, birthDay, hourlyRate);
                                break;
                            case "5":
                                employee = new JrResearcher(firstName, lastName, email, birthDay, hourlyRate);
                                break;
                        }

                        employees.Add(employee);
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Loaded {employees.Count} employees!\n\n");
                    //Console.ResetColor();
                }
            }
            catch (IndexOutOfRangeException iex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Something went wrong parsing the file, please check the data!");
                Console.WriteLine(iex.Message);
                //Console.ResetColor();
            }
            catch (FileNotFoundException fnfex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The file could not be found!");
                Console.WriteLine(fnfex.Message);
                File.AppendAllText(errorpath, $"{DateTime.Now.ToString()}\n");
                File.AppendAllText(errorpath, $"{ fnfex.StackTrace}\n");
                //Console.ResetColor();

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Something went wrong while loading the file!");
                Console.WriteLine(ex.Message);
                //Console.ResetColor();

            }
            finally 
            {
                Console.ResetColor();

            }

        }

        internal static void LoadEmployeeById(List<Employee> employees)
        {
            try
            {
                Console.Write("Enter the employee ID to see their info: \n");

                int selectedId = int.Parse(Console.ReadLine());
                Employee selectedEmployee = employees[selectedId];
                selectedEmployee.DisplayEmployeeDetails();
            }
            catch(FormatException fex)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Please enter the ID as a number\n\n");
                Console.ResetColor();
            }
        }
        #endregion
    }
}
