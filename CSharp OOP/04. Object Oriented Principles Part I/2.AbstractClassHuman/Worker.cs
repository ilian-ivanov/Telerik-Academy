using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassHuman
{
    public class Worker : Human
    {
        private double weekSalary;
        private int workHourPerDay;

        // CONSTRUCTOR ------------------------------------------------------------
        public Worker(string firstName, string lastName, double weekSalary, int workHourPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHourPerDay = workHourPerDay;
        }

        // PROPERTIES ----------------------------------------------------------------
        public double WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value > 0)
                {
                    this.weekSalary = value;
                }
                else
                {
                    throw new ArgumentException("The week salary must be positive number!");
                }

            }
        }

        public int WorkHourPerDay
        {
            get { return this.workHourPerDay; }
            set
            {
                if (value > 0 && value < 15)
                {
                    this.workHourPerDay = value;
                }
                else
                {
                    throw new ArgumentException("The work hours must be between 1 and 14 including!");
                }
            }
        }

        // METHODS ---------------------------------------------------------------------
        public double MoneyPerHour()
        {
            return this.weekSalary / (this.workHourPerDay * 5);
        }

        public string GetFirstName()
        {
            return this.FirstName;
        }

        public string GetLastName()
        {
            return this.LastName;
        }

        public override string ToString()
        {
            return string.Format("I am {0} {1}. My salary per hour is {2:F2}.", 
                GetFirstName(), GetLastName(),MoneyPerHour());
        }
    }
}
