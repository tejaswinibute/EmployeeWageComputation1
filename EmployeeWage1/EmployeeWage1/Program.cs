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

            PartTimeWage PartTimeWage = new PartTimeWage();
            PartTimeWage.EmployeePartTimeWage();

            SwitchStatement switchwage = new SwitchStatement();
            switchwage.SwitchDailyWage();

            Console.WriteLine("Total Monthly wage is :- ");
            MonthWage monthWage = new MonthWage();
            monthWage.MonthlyWage();

        }
    }
}
