using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.HR
{
    internal interface IEmployee
    {
        double RecieveWage(bool resetHours = true);
        void GiveBonus();
        //public double? CalculateBonusAndBonusTax(double? bonus, double? HourlyRate, out double? bonusTax);
        double CalculateBonusAndBonusTax();
        void PerformWork();
        void PerformWork(int numberOfHours);
        void DisplayEmployeeDetails();
        void GiveCompliment();
    }
}
