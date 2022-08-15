using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage1
{
    internal class EmployeePresentAbsent
    {
        public void PresentAbsent()
        {
            //Class name object name = new (keyword) Classname();
            Random EmpCheck = new Random();
            int Check = EmpCheck.Next(0, 2);
            int EmployeePresent = 1;

            if (Check == EmployeePresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }

    }
}
