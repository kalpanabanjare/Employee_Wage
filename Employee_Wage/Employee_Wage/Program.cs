using System;

namespace Employee_Wage
{
    class EmployeeWageComputation
    {
        private float EmpWagePerHour = 20;
        public int FullTime_WorkingHrs_PerDay = 8;
        public int PartTime_WorkingHrs_PerDay = 4;
        public int MAX_WORKING_HRS = 100;
        public int MAX_WORKING_DAYS = 20;
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int IS_ABSENT = 0;
        float EmpDailyWage = 0;
        public float TotalWage = 0;
        public EmployeeWageComputation(int EmpWagePerHour, int FullTime_Working_PerDay, int PartTime_WorkingHrs_PerDay, int MAX_WORKING_HRS, int MAX_WORKING_DAYS)
        {
            this.EmpWagePerHour = EmpWagePerHour;
            this.FullTime_WorkingHrs_PerDay = FullTime_Working_PerDay;
            this.PartTime_WorkingHrs_PerDay = PartTime_WorkingHrs_PerDay;
            this.MAX_WORKING_HRS = MAX_WORKING_HRS;
            this.MAX_WORKING_DAYS = MAX_WORKING_DAYS;
        }
        private int IsEmployeePresent()
        {
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            return empcheck;
        }
        public void CalculateWage()
        {
            int DayNumber = 1;
            int EmpWorkingHrs = 0;
            int TotalWorkingHrs = 0;
            int WorkingDay = 0;
            while (DayNumber <= MAX_WORKING_DAYS && TotalWorkingHrs <= MAX_WORKING_HRS)
            {
                Console.WriteLine("Day: " + (DayNumber));
                switch (IsEmployeePresent())
                {
                    case IS_ABSENT:
                        Console.WriteLine("Employee is Absent");
                        EmpWorkingHrs = 0;
                        break;
                    case IS_PART_TIME:
                        Console.WriteLine("Employee is Present");
                        Console.WriteLine("Employee is Part time");
                        EmpWorkingHrs = PartTime_WorkingHrs_PerDay;
                        WorkingDay++;
                        break;
                    case IS_FULL_TIME:
                        Console.WriteLine("Employee is Present");
                        Console.WriteLine("Employee is Full time");
                        EmpWorkingHrs = FullTime_WorkingHrs_PerDay;
                        WorkingDay++;
                        break;
                }
                EmpDailyWage = EmpWorkingHrs * EmpWagePerHour;
                TotalWage += EmpDailyWage;
                DayNumber++;
                TotalWorkingHrs += EmpWorkingHrs;
                Console.WriteLine("Working hours: " + EmpWorkingHrs);
                Console.WriteLine("Daily Wage: " + EmpDailyWage);
            }
            Console.WriteLine("\nTotal working hours: " + TotalWorkingHrs + "\nTotal working Days: " + WorkingDay + "\nTotal Wage: " + TotalWage);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            EmployeeWageComputation employeeWagecomputation = new EmployeeWageComputation(20, 8, 4, 100, 20);
            employeeWagecomputation.CalculateWage();
        }
    }
}