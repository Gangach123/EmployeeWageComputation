using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeWageComputation
    {
        static void Main(string[] args)
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int IS_ABSENT = 0;
            const int WAGE_PER_HOUR = 20;
            const int TOTAL_WORKING_DAYS = 20;
            const int MAX_HRS_WORKED = 100;
            int workingHours = 8;
            int totalWorkingHrs = 0;
            int workingDays = 0;

            while (workingDays < TOTAL_WORKING_DAYS && totalWorkingHrs < MAX_HRS_WORKED)
            {
                Random random = new Random();
                int employeeCheck = random.Next(0, 3);
                switch (employeeCheck)
                {
                    
                    case IS_PART_TIME:
                        //Console.WriteLine("Employee is working for parttime");
                        workingHours = 8;
                        return workingHours;
                        break;

                    case IS_FULL_TIME:
                        //Console.WriteLine("Employee is working for fulltime");
                        workingHours = 8;
                        return workingHours;
                        break;

                    default:
                        //Console.WriteLine("Employee is absent");
                        workingHours = 0;
                        return workingHours;
                        break;
                }
                totalWorkingHrs = totalWorkingHrs + workingHours;
                workingDays++;
            }
            int empWage = totalWorkingHrs * WAGE_PER_HOUR;
            Console.WriteLine($"Employee wage {empWage}");
            Console.ReadLine();

        }
    }
}
