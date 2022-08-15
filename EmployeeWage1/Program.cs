namespace EmployeeWage1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EmployeePresentAbsent employee = new EmployeePresentAbsent();
            employee.PresentAbsent();

            DailyWage wage = new DailyWage();
            wage.DailyWage();

            PartTimeFullTime PartTimeFullTime = new PartTimeFullTime();
            PartTimeFullTime.EmployeePartTimeFullTime();

            SwitchStatement switchwage = new SwitchStatement();
            switchwage.SwitchDailyWage();

            Console.WriteLine("Total Monthly wage is :- ");
            MonthWage monthWage = new MonthWage();
            monthWage.MonthlyWage();

        }
    }
}
