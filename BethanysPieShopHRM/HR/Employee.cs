using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.HR
{
    public class Employee : IEmployee
    {

        private string firstName;
        private string lastName;
        private string email;

        private int numberOfHoursWorked;
        private double wage;
        private double? hourlyRate;

        private DateTime birthDay;

        const int minimalHoursWorkedUnit = 1;

        private Address address;

        public static double taxRate = 0.15;

      

        public string FirstName
        {
            get => firstName;
            // same as get { return = firstName; }
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public int NumberOfHoursWorked
        {
            get => numberOfHoursWorked;
             protected set => numberOfHoursWorked = value;
        }

        public double Wage
        {
            get => wage;
            private set => wage = value;
        }

        public double? HourlyRate
        {
            get => hourlyRate;
            set => hourlyRate = hourlyRate < 0 ? (double?)0 : value;
            //{
            //    if (hourlyRate < 0)
            //    {
            //        hourlyRate = 0;
            //    }
            //    else
            //    {
            //        hourlyRate = value;
            //    }
            //} This is simplified to the preceding argument


        }

        public DateTime BirthDay
        {
            get => birthDay;
            set => birthDay = value;
        }

        public Address Address
        {
            get => address;
            set => address = value;
        }


        public Employee(string firstName, string lastName, string email, DateTime birthday) : this(firstName, lastName, email, birthday, 0)
        {
        }

        public Employee(string firstName, string lastName, string email, DateTime birthday, double? hourlyRate)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthday;
            HourlyRate = hourlyRate ?? 10;
      
        }

        public Employee(string firstName, string lastName, string email, DateTime birthday, double? hourlyRate, string street, string houseNumber, string zip, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthday;
            HourlyRate = hourlyRate ?? 10;

            Address = new Address(street, houseNumber, zip, city);

        }
        public void PerformWork()
        {
            //numberOfHoursWorked++;
            PerformWork(minimalHoursWorkedUnit);
            //Console.WriteLine($"{firstName} {lastName} has recieved {wage} for {numberOfHoursWorked} hour(s) of work.");
        }


        public void PerformWork(int numberOfHours)
        {
            NumberOfHoursWorked += numberOfHours;

            Console.WriteLine($"{FirstName} {LastName} has worked for {numberOfHours} hour(s).");
        }


        public int CalculateBonus(int bonus)
        {
            if (numberOfHoursWorked > 10)
                bonus *= 2;

            Console.WriteLine($"The employee got a bonus of {bonus}!");
            return bonus;
        }


        public int CalculateBonusAndBonusTax(int bonus, out int bonusTax)
        {
            bonusTax = 0;
            if (NumberOfHoursWorked > 10)
                bonus *= 2;

            if (bonus >= 200)
                bonusTax = bonus / 10;
            bonus -= bonusTax;

            Console.WriteLine($"The employee got a bonus of {bonus} and the tax on the bonus is {bonusTax}");
            return bonus;
        }

        public virtual void GiveBonus()
        {
            Console.WriteLine($"{FirstName} {LastName} recieved a generic bonus of 100!");
        }

        public double RecieveWage(bool resetHours = true)
        {
            double wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value;
            double taxAmount = wageBeforeTax * taxRate;

            Wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"{FirstName} {LastName} has recieved {Wage} for {NumberOfHoursWorked} hour(s) of work");

            if (resetHours)
                numberOfHoursWorked = 0;

            return Wage;

        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: \t{FirstName}\nLast name: \t{LastName}\nEmail: \t\t{Email}\nBirthday: \t{BirthDay.ToShortDateString()}\n");
        }

        public void GiveCompliment()
        {
            Console.WriteLine($"You've done a great job, {FirstName}!");
        }
    }
}
