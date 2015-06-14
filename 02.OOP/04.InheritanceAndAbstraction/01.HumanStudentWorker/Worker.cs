using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudentWorker
{
    class Worker : Human
    {
        private double weekSalary;
        private int workHoursPerDay;
        

        public Worker(string firstName, string lastName, double weekSalary, int workHoursPerday) 
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerday;
        }

        public double WeekSalary { get; set; }

        public int WorkHoursPerDay { get; set; }


        public double MoneyPerHour()
        {
            double result = this.WeekSalary/ this.WorkHoursPerDay / 5;
            return result;
        }
    }
}
