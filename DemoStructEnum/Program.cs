using System;
using static System.Console;
namespace DemoStructEnum
{
    struct Employee
    {
        public int id;
        public float salary;
        public char gender;
        public bool status;
        public string name;//reference type variable
    }
    enum categories { Mobile=10,Laptop,Memory_disk}
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp;//value type variable
            emp.id = 100;
            emp.salary = 25000;
            emp.gender = 'M';
            emp.status = true;
            emp.name = "Ajay";
            Console.WriteLine($"Employee Details \n Name: {emp.name} \n Id: {emp.id} \nSalary: {emp.salary} \nGender: {emp.gender} \nStatus: {emp.status} \n");
            string state = "TN";
            categories product = categories.Laptop;
            WriteLine(product);
            WriteLine((int)product);
            product = (categories)12;
            WriteLine(product);
            Console.ReadLine();
        }
    }

}
