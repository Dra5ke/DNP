using System;
using System.Collections.Generic;

namespace Exercise_2
{
    class Company
    {
        private List<Employee> employees;

        public Company() => employees = new List<Employee>();

        public double GetMonthlySalaryTotal()
        {
            double sum = 0;

            foreach (Employee employee in employees)
            {
                sum += employee.GetMonthSalary();
            }

            return sum;
        }

        public void EmployNewEmployee(Employee newEmployee)
        {
            employees.Add(newEmployee);
        }
    }

    abstract class Employee
    {
        private String name;

        public Employee(String name) => this.name = name;

        public abstract double GetMonthSalary();
    }

    class PartTimeEmployee : Employee
    {
        private double hourlyWage;
        private int hoursPerMonth;

        public PartTimeEmployee(double hourlyWage, int hoursPerMonth, String name)
        : base(name)
        {
            this.hourlyWage = hourlyWage;
            this.hoursPerMonth = hoursPerMonth;
        }

        public override double GetMonthSalary()
        {
            return hourlyWage * hoursPerMonth;
        }
    }

    class FullTimeEmployee : Employee
    {
        private double monthlySalary;

        public FullTimeEmployee(double monthlySalary, String name) : base(name) => this.monthlySalary = monthlySalary;

        public override double GetMonthSalary()
        {
            return monthlySalary;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
