// See https://aka.ms/new-console-template for more information
using BethanysPieShopHRM;
using BethanysPieShopHRM.HR;

Console.WriteLine("Creating an Employee");
Console.WriteLine("---------------------\n");

IEmployee bethany = new StoreManager("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);
Manager mary = new("Mary", "Smith", "mary@snowball.be", new DateTime(1965, 1, 16), 30);

Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30);
Employee jake = new ("Jake", "Nicols", "jake@snowball.be", new DateTime(1995, 8, 16), 25, "New Street", "123", "123456", "Pie Ville");


JrResearcher jerry = new("Jerry", "Smith", "jerry@snowball.be", new DateTime(1930, 1, 12), 17);

Developer ian = new("Ian", "Block", "ian@snowball.be", new(1970, 12, 12), 50);


Console.WriteLine("---------------------\n");
Console.WriteLine("Creating an Employee");

//List<IEmployee> employees = new List<IEmployee>();
//employees.Add(bethany);
//employees.Add(george);
//employees.Add(jake);
//employees.Add(ian);

//foreach(Employee employee in employees)
//{
//    employee.DisplayEmployeeDetails();
//    employee.GiveBonus();
//    employee.GiveCompliment();
//}


bethany.DisplayEmployeeDetails();
bethany.PerformWork(2);
bethany.PerformWork(2);
bethany.PerformWork(2);
bethany.PerformWork(5);
bethany.CalculateBonusAndBonusTax();
bethany.GiveBonus();
bethany.RecieveWage();

mary.DisplayEmployeeDetails();
mary.PerformWork(2);
mary.PerformWork(2);
mary.PerformWork(2);
mary.PerformWork(2);
mary.AttendManagerMeeting();
mary.RecieveWage();

jerry.ResearchNewPieTastes(5);
jerry.ResearchNewPieTastes(5);
jerry.ResearchNewPieTastes(5);


//int[] sampleArray = new int[5];

//int[] sampleArray2 = new int[] { 1, 2, 3, 4, 5 };
////int[] sampleArray3 = new int[5] { 1, 2, 3, 4, 5, 6 };//Arrays in C# are fixed in size when created, cannot be changed

//int length = int.Parse(Console.ReadLine());

//int[] employeeIds= new int[length];

//var testId = employeeIds[0];
////var errorId = employeeIds[length];

//for (int i = 0; i < length; i++)
//{
//    Console.WriteLine("Enter the Employee ID: ");
//    int id = int.Parse(Console.ReadLine()); //Assuming the user wil always enter an int value
//    employeeIds[i] = id;
//}

//Employee mysteryEmployee = null;
//mysteryEmployee.DisplayEmployeeDetails();

//bethany.PerformWork(25);

//string name = "bethany";
//string anotherName = name;
//name += " smith";

//Console.WriteLine($"Name: {name}");
//Console.WriteLine($"Another name: {anotherName}");

//int minimumBonus = 100;
//int bonusTax;
//int recievedBonus = bethany.CalculateBonusAndBonusTax(minimumBonus, out bonusTax);
//Console.WriteLine($"The minimum bonus is {minimumBonus}, the bonus tax is {bonusTax} and {bethany.firstName} has recieved a bonus of {recievedBonus}.");


//bethany.DisplayEmployeeDetails();

//bethany.PerformWork();
//bethany.PerformWork();
//bethany.PerformWork(5);
//bethany.PerformWork();

//double recievedWageBethany = bethany.RecieveWage(true);
//Console.WriteLine($"Wage paid (message from Program): {recievedWageBethany}");

//WorkTask task;
//task.description = "Bake delicious pies";
//task.hours = 3; ;
//task.PerformWorkTask();

//List<int> employeeIds= new List<int>();
//employeeIds.Add(55);
//employeeIds.Add(65);
//employeeIds.Add(45);
