using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeWageComputation
    {
        static void Main1(string[] args)
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int IS_ABSENT = 0;
            const int WAGEPERHOUR = 20;
            const int TOTALWORKINGDAYS = 20;

            int workingHours = 8;
            int totalWorkingHrs = 0;

            for (int i = 0; i < TOTALWORKINGDAYS; i++)
            {
                Random random = new Random();
                int employeeCheck = random.Next(0, 3);
                switch (employeeCheck)
                {
                    
                    case IS_PART_TIME:
                        Console.WriteLine("Employee is part-time working");
                        workingHours = 8;
                        break;
                    case IS_FULL_TIME:
                        Console.WriteLine("Employee is present");
                        workingHours = 8;
                        break;
                    default:
                        Console.WriteLine("Employee is absent");
                        workingHours = 0;
                        break;
                }
                totalWorkingHrs = totalWorkingHrs + workingHours;
            }
            int empWage = totalWorkingHrs * WAGEPERHOUR;
            Console.WriteLine($"Employee earning money {empWage}");
            Console.ReadLine();

        }
    }
}
