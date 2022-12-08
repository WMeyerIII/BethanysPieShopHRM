using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
    internal class Utilities
    {
        
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

    }
}
