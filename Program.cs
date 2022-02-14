using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class EmployeeWageComputation
    {
        public static void Main(string[] args)

        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int IS_ABSENT = 0;
            Console.WriteLine($"Employee Wage Calculator");
            int workingHr = 1;
            int perHrSalary = 20;

            Random random = new Random();
            int present = (random.Next(0,3));

            switch (present)
            {

                case IS_PART_TIME:
                    Console.WriteLine("Employee is absent");
                    workingHr = 8;
                    break;

                case IS_FULL_TIME:
                    Console.WriteLine("Employee is present");
                    workingHr = 8;
                    break;
                default:
                    Console.WriteLine("Employee is absent");
                    break;
            }

            int salary = perHrSalary * workingHr;
            Console.WriteLine($"Salary {salary}");
            Console.ReadLine();

        }
    }
}

