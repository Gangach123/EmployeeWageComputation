using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeWageComputation
    {
        static int WorkingHours()
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

                Random random = new Random();
                int employeeCheck = random.Next(0, 3);
                switch (employeeCheck)
                {
                    
                    case IS_PART_TIME:
                        Console.WriteLine("Employee is working for parttime");
                        workingHours = 8;
                        break;

                    case IS_FULL_TIME:
                        Console.WriteLine("Employee is working for fulltime");
                        workingHours = 8;
                        break;

                    default:
                        Console.WriteLine("Employee is absent");
                        workingHours = 0;
                        break;
                }
          
            }
            static void Main(string[] args)
            {
            const int WAGEPERHOUR = 20;
            const int TOTALWORKINGDAYS = 20;
            const int MAXHRSWORKED = 100;


            int workingHrs = 0;
            int totalWorkingHrs = 0;
            int workingDays = 0;
            int totalWage = 0;
            int[] dailyWageArray = new int[20];
            int[] totalWageArray = new int[20];

            while (workingDays < TOTALWORKINGDAYS && totalWorkingHrs < MAXHRSWORKED)
            {
                workingHrs = WorkingHours();
                dailyWageArray[workingDays] = WAGEPERHOUR * workingHrs;
                totalWage = totalWage + WAGEPERHOUR * workingHrs;
                totalWageArray[workingDays] = totalWage;
                totalWorkingHrs = totalWorkingHrs + workingHrs;
                workingDays++;

            }
            int empWage = totalWorkingHrs * WAGEPERHOUR;
            Console.WriteLine($"Employee earned Money {empWage}");
            Console.WriteLine(String.Join(" ", dailyWageArray));
            Console.WriteLine(String.Join(" ", totalWageArray));
            Console.ReadLine();

        }

    }
              
}
