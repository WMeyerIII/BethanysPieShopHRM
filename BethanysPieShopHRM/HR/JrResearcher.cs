using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.HR
{
    internal class JrResearcher : Researcher
    {
        public JrResearcher(string firstName, string lastName, string email, DateTime birthday, double? hourlyRate) : base(firstName, lastName, email, birthday, hourlyRate)
        {
        }
    }
}
