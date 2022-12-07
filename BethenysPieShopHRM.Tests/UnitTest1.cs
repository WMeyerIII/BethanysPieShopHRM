using BethanysPieShopHRM.HR;


namespace BethenysPieShopHRM.Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void PerformWork_Adds_NumberOfHours()
        {
            //Arrange
            Employee employee = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);
            

            //Act

            //Assert
        }
    }
}