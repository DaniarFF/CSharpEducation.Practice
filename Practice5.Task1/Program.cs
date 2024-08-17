using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Practice5.Task1
{
    public class Employee                           
    {
        public string Name{get ; set;}
        public decimal Salary { get ; set;}
        public virtual decimal CalculateBonus() 
        {
            return decimal.Multiply(0.1m, Salary);
        }

        public Employee(string name, decimal salary) 
        { 
            Name = name;
            Salary = salary;
        }
        public Employee(string name)
        {
            Name = name;
        }
    }

    public class Manager : Employee 
    {
        public int TeamSize { get; set;}

        public override decimal CalculateBonus()
        {         
            Salary = base.CalculateBonus() * 2;
            if (TeamSize > 5) 
            {
                Salary =+ decimal.Multiply(Salary, 0.05m);
            }
            return Salary;
        }
        public Manager(string name, int teamSize, decimal salary) : base(name, salary)
        { 
            TeamSize = teamSize;
        }
    }
    public class Constractor : Employee
    { 
        public double HourlyRate 
        {
            get
            {
                return this.HourlyRate;
            }
            set
            {
                this.HourlyRate = 5;
            } 
        } 
        public new decimal CalculateBonus(double hoursWorked)
        {
            return (decimal)(HourlyRate * hoursWorked);
        }
        public Constractor(string name, double hoursWorked) : base(name) 
        { 
            HourlyRate = hoursWorked;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee("Biba", 50000),
                new Employee("Boba", 65000),
                new Employee("Babe", 67000),
                new Manager("Teleboba", 5, 23000),
                new Constractor("Gigaboba", 20), 
            };

            foreach (var employee in employees)
            {
                if (employee is Constractor contractor)
                {
                    decimal contractorBonus = contractor.CalculateBonus(15); 
                }
                if (employee is Manager manager)
                {
                    decimal contractorBonus = manager.CalculateBonus();
                }
                else
                {
                    decimal employeeBonus = employee.CalculateBonus();
                }
            }
        }
    }
}

