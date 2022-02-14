using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDailyWage
{
    internal class EmployeeDailyWage
    {


        public static void Main(string[] args)
        {
            const int IS_FULL_TIME = 1;
            const int EMP_RATE_PER_HOUR = 20;
            const int IS_ABSENT = 0;
            int WORKING_HOURS = 8;


            //variables
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
                WORKING_HOURS = 8;
            
            // empHrs = 0;
            empWage = WORKING_HOURS * EMP_RATE_PER_HOUR;
            Console.WriteLine($"Employee Daily Earned Money {empWage}");
            Console.Read();
        }

    }

}
