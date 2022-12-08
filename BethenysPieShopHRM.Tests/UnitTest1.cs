using BethanysPieShopHRM.HR;


namespace BethenysPieShopHRM.Tests
{
    public class EmployeeTests
    {

        Employee employee = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);

        [Fact]
        public void PerformWork_Adds_NumberOfHours()
        {
            //Arrange

            int numberOfHours = 3;

            //Act
            employee.PerformWork(numberOfHours);

            //Assert
            Assert.Equal(numberOfHours, employee.NumberOfHoursWorked);
        }

        [Fact]
        public void PerformWork_Adds_DefaultNumberOfHours_IfNoValueSpecified()
        {
            //Arrange
            Employee employee = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);

            //Act
            employee.PerformWork();

            //Assert
            Assert.Equal(1, employee.NumberOfHoursWorked);
        }

        //[Fact]
        //public void CalcuateBonus_Multiplies_Bonus_WhenNumberOfHoursIsGreaterThan10()
        //{
        //    int numberOfHours = 11;

        //    calculateBonus(nu)
        //}
    }
}