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

        public void LoadEmployees_Creates_Error_Log_On_Error_Throw()
        {
            //Arrance
            string path = @"\data\BethanysPieShopHRM\";
            string wrongEmployeeSaveFile = "employee2.txt";
            string errorlog = "errorlog.txt";

            //This doesn't work because I can't alter the filename within the method. Would have to extract out the path to a different method?
            //Act
            
            //Assert
        }
    }
}