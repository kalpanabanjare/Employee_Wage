using System;

namespace Employee_Wage
{
    class Program
    {
        public const int is_part_time = 1;
        public const int is_full_time = 2;
        public const int Emp_per_rate = 20;
        public const int num_of_working_days = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program.");
            int EmpHr = 0;
            int Emp_wage = 0;
            int totalEmpwage = 0;
            for (int day = 0; day < num_of_working_days; day++)
            {
                Random random_check = new Random();
                int empCheck = random_check.Next(0, 3);
                switch (empCheck)
                {
                    case is_part_time:
                        EmpHr = 4;
                        Console.WriteLine("Employee is Present");
                        Console.WriteLine("Employee is Part time");
                        break;
                    case is_full_time:
                        EmpHr = 8;
                        Console.WriteLine("Employee is Present");
                        Console.WriteLine("Employee is Full time");
                        break;
                    default:
                        EmpHr = 0;
                        Console.WriteLine("Employee is Absent");
                        break;
                }
                Emp_wage = (Emp_per_rate * EmpHr);
                totalEmpwage += Emp_wage;
                Console.WriteLine("Daily emp wage: " + Emp_wage);
            }
            Console.WriteLine("\nTotal Emp Wage: " + totalEmpwage);
        }
    }
}