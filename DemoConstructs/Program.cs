using System;
using static System.Console;
namespace DemoConstructs
{
    class Program
    {
        static void Main(string[] args)
        {

            //SelectIfelse();
            // SwitchCase();
            DemoLoop();
        }
        static void DemoLoop()
        {
            int i = 1;
            //while loop
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
            //do--while loop
            int j = 1;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j <= 10);
            //for loop
            WriteLine("Enter the number for multiplication table");
            int num = int.Parse(Console.ReadLine());
            for (int x = 1; x <= 10; x++)
            { Console.WriteLine($"{x}*{num}={x * num}"); }
            //use of break and continue keyword
            for (var k = 1; k <= 10; k++)
            {
                if (k == 5) continue;
                Console.WriteLine(k);
            }
            //nested for loop
            for (int a = 1; a < 4; a++)
            {
                for (int b = 0; b < a; b++)
                {
                    Console.Write("*" + "\t");

                }
                Console.WriteLine();
            }
        }
        static void SwitchCase()
        {
            char option;
            Console.WriteLine("Enter your option ");
            Console.WriteLine("A.Insert\nB.Update\n C.Delete\n D.Exit");
            option = char.Parse(Console.ReadLine());
            switch (option)
            {
                case 'a':
                case 'A':
                    Console.WriteLine("Data got inserted");
                    break;
                case 'b':
                case 'B':
                    Console.WriteLine("Data got updated");
                    break;
                case 'C':
                    Console.WriteLine("Data got deleted");
                    break;
                case 'D':
                    Console.WriteLine("Thank you");
                    break;
                default: Console.WriteLine("Not a valid option"); break;
            }
        }
        static void SelectIfelse()
        {
            Console.WriteLine("enter marka");
            int mark = int.Parse(Console.ReadLine());
            if (mark >= 50 && mark < 60)
            { Console.WriteLine("You passed the Exam and your grade is D"); }
            else if (mark >= 60 && mark < 70)
                Console.WriteLine("You passed the Exam and your grade is C");
            else if (mark >= 70 && mark < 80)
                Console.WriteLine("You passed the Exam and your grade is B");
            else if (mark >= 80 && mark < 90)
                Console.WriteLine("You passed the Exam and your grade is A");
            else if (mark >= 90 && mark <= 100)
                Console.WriteLine("You passed the Exam and your grade is A+");
            else if ( mark > 100)
                Console.WriteLine("invalid Score");
            else
                Console.WriteLine("Sorry---You failed the Exam");
        }
    }
    }
