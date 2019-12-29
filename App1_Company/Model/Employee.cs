namespace App1_Company.Model
{
    public class Employee : Person
    {
        private double Salary { get; set; }

        public Employee() { }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public double CalcSalary()
        {
            if(Salary < 1600.00)
            {
                return Salary += 300.00;
            }
            else
            {
                return Salary += 150.00;
            }
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Salary: R$ " + Salary.ToString("F2") + ", New Salary: R$ " + CalcSalary().ToString("F2");
        }
    }
}
