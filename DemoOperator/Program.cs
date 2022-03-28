using System;
using static System.Console;
using static System.Convert;
namespace DemoOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 2 numbers");
            //int i = Convert.ToInt32(Console.ReadLine());
            //int j = ToInt32(Console.ReadLine());
            //Console.WriteLine(i + j);
            // Console.WriteLine(i - j);
            // Console.WriteLine(i * j);
            // Console.WriteLine(i / j);
            // Console.WriteLine(i % j);
            // Console.WriteLine(i > j);
            // Console.WriteLine(i < j);
            // Console.WriteLine(i >= j);
            // Console.WriteLine(i == j);
            // Console.WriteLine(i > j && i == j);
            // Console.WriteLine(i > j || i == j);
            // Console.WriteLine(!(i > j));
            int a = Convert.ToInt32(Console.ReadLine());
            int b = ToInt32(Console.ReadLine());
            WriteLine(a > b ? a : b);//ternary operator  simplified if else
            WriteLine(a > b ? "first no is largest" : "second number is largest");
            WriteLine((a > b && b % 2 == 0) ? a : b);
            string str = "Hello";
            WriteLine(str.Length);//'.' operator used to access property of a variable

            WriteLine(a is int);//is used to check the type of a data

            object o = a as object;//kind of type casting used to change the data type to base type
            WriteLine(o);
            o = str as string;
            WriteLine(o);

            WriteLine(typeof(string));//get the system datatype of variables

            int x = int.MaxValue;
            int y = int.MinValue;
            WriteLine(x + "    " + y);
           //checked//this operator will monitor the error
            {
                x += 2;
                WriteLine(x);
            }
           unchecked//this operator will not monitor the error
            {
                x += 2;
                WriteLine(x);
            }



        }
    }
}
