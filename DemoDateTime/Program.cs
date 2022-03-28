using System;

namespace DemoDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2022, 03, 03);
            Console.WriteLine(date);
            date = DateTime.Now;
            Console.WriteLine(date);
            Console.WriteLine("enter the date");
            date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(date);
            Console.WriteLine(date.ToString("M"));
            Console.WriteLine(date.ToString("f"));
            Console.WriteLine(date.ToString("F"));
            Console.WriteLine(date.ToString("d"));
            Console.WriteLine(date.ToString("D"));
            Console.WriteLine(date.ToString("dddd"));
            Console.WriteLine("enter the rhyme");
            string [] rhyme =(Console.ReadLine().Split(" "));
            Array.Reverse(rhyme);
            foreach(string str in rhyme)
            {
                Console.Write(str + " ");
            }
        }
    }
}
