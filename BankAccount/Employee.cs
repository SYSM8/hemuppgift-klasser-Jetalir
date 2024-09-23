using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Employee
    {

        private string name { get; set; }
        private int age { get; set; }
        private double salary { get; set; }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    age = 0;
                }
            }

        }
        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value >= 0)
                {
                    salary = value;
                }

            }

        }

        public Employee(string FirstName)
        {
            Name = FirstName;
        }

        public double GetAnnualSalary()
        {
            return Salary * 12;
        }
        public void GiveRaise(double precentage)
        {
            Salary += (precentage / 100) * Salary;
        }
        public void DisplayEmployeeinfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }
}
