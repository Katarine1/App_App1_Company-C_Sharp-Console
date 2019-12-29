using System;
using System.Globalization;
using App1_Company.Model;

namespace App1_Company
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("\t\t# -- Company -- #\n");
            Console.Write("\t\tEnter Name: ");
            string name = Console.ReadLine();
            Console.Write("\t\tEnter Salary: ");
            string salary = Console.ReadLine();
            double sal = double.Parse(salary, CultureInfo.InvariantCulture);

            Console.WriteLine();
            Employee em = new Employee(name, sal);
            Console.WriteLine("\t\t" + em);
        }
    }
}
