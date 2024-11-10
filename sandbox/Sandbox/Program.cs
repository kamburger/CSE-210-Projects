using System;

class Program
{
    static void Main(string[] args)
    {
        public class Employee
        {
            private string _name;
            public virtual double CalculatePay()
            {
                return 0;
            }
        }

        public class Salary : Employee
        {
            private double _salary()
            public override double CalculatePay()
            {
                return _salary/26
            }
        }
        public class Hourly : Employee
        {
            private double _hoursWorked;
            private double _hourlyRate;
            public override double CalculatePay()
            {
                return _hourlyRate*_hoursWorked
            }
        }
        public class Volunteer : Employee
        {
            
        }


        
    }
}

