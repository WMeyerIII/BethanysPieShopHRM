﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.HR
{
    internal class Researcher : Employee
    {
        public Researcher(string firstName, string lastName, string email, DateTime birthday, double? hourlyRate) : base(firstName, lastName, email, birthday, hourlyRate)
        {
        }

        private int numberOfPieTastesInvented = 0;

        public int NumberOfPieTastesInvented
        {
            get => numberOfPieTastesInvented;
            private set => numberOfPieTastesInvented = value;
        }

        public void ResearchNewPieTastes(int researchHours)
        {
            NumberOfHoursWorked += researchHours;

            if (new Random().Next(100) > 50)
            {
                numberOfPieTastesInvented++;

                Console.WriteLine($"Researcher {FirstName} {LastName} has invented a new pie taste! Total number of pies invented: {NumberOfPieTastesInvented}");
            }
            else
            {
                Console.WriteLine($"Researcher {FirstName} {LastName} is working still on a new pie taste!");
            }
        }
    }
}
