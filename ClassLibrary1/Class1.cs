namespace ClassLibrary1
{
    public class BankAccount
    {
        private decimal _balance;
        public string AccountName { get; set; }

        public BankAccount(string accountName, decimal initialBalance)
        {
            AccountName = accountName;
            _balance = initialBalance;
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public void Deposit(decimal amount)
        {
            _balance += amount;
            if (amount < 0)
            {
                Console.WriteLine(_balance);
            }
        }

        public void Withdraw(decimal amount)
        {
            _balance -= amount;
            if (amount > _balance)
            {
                Console.WriteLine(_balance);
            }
            
        }
    }

    public class Customer
    {
        private string _name;
        private int _age;
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }

        public Customer(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string GetCustomerDetails()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }

    public class Employee
    {
        protected string _employeeId;
        public Employee(string employeeId)
        {
            _employeeId = employeeId;
        }

        public string GetEmployeeId()
        {
            return _employeeId;
        }
    }

    public class Manager : Employee
    {
        public string Department { get; set; }

        public Manager(string employeeId, string department) : base(employeeId)
        {
            Department = department;
        }
    }

    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed {  get; set; }
        public virtual string MakeSound()
        {
            return "Generic animal sound";
        }
        public virtual string Eat()
        {
            return "Animal is eating.";
        }
    }
    public class Dog : Animal
    {
        public override string MakeSound()
        {
            return "Woof!";
        }
    }
    public class Cat : Animal
    {
        public override string MakeSound()
        {
            return "Meow!";
        }
    }
    public class Mammal : Animal
    {
        public override string Eat()
        {
            return "Animal is eating.";
        }
        public virtual string GiveBirth()
        {
            return "Mammal is giving birth.";
        }
    }
    public class Human : Mammal
    {
        public override string Eat()
        {
            return "Animal is eating.";
        }
        public string Talk()
        {
            return "Human is talking.";
        }
        public override string GiveBirth()
        {
            return "Mammal is giving birth.";
        }
    }

    public abstract class Shape()
    {
        public abstract double Area();
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return Width * Height;
        }
    }

}