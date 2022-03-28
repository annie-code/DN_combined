using System;

namespace DemoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //datatype []arrayName;arryName=new datatype[size];
            // int[] numbers = new int[] { 1, 2, 3, 4 };
            // int[] numbers =  { 1, 2, 3, 4 };
            // int[,] marks = new int[2, 4] { { 1, 2, 3, 4 }, { 8, 9, 6, 7 } };
            //int[][] batch = new int[3][];
            //batch[0] = new int[5];
            //batch[1] = new int[2];
            //batch[2] = new int[3];
            // DemoSingle();
            // DemoDouble();
            DemoJagged();
        }
        static void DemoJagged()
        {
            // string[,] batch = new string[5, 40];//normal 2d array rach row should have 40 columns even if not utilized fully
            string[][] batch = new string[5][];//declaration of jagged array with 5 rows column size can be decided dynamically
            Console.WriteLine("Ener candidate details for each batch");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter number of candidate for batch" + (i + 1));
                int num = int.Parse(Console.ReadLine());
                batch[i] = new string[num];//dynamic memory allocation to each row of jagged array
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter details for batch" + (i + 1));
                for (int j = 0; j < batch[i].Length; j++)
                {
                    Console.WriteLine("Enter name of candidate ");
                    batch[i][j] = Console.ReadLine();
                }
            }
            for (int i = 0; i < 5; i++)
            {
                // foreach(string x in batch[i])
                for (int x = 0; x < batch[i].Length; x++)
                {
                    //Console.Write(x + "\t");
                    Console.Write(batch[i][x] + "\t");
                }
                Console.WriteLine();
            }
          
            int[][] arr = new int[2][] { new int[] { 0, 1 }, new int[] { 3, 4, 7 } };//declaration and initialization
            int[][] arr1 = { new int[] { 0, 1 }, new int[] { 3, 4, 7 } };//declaration and initialization

            arr[1][1] = 34;

            for (int i = 0; i < 2; i++)
            {
                foreach (int j in arr[i])
                {
                    Console.Write(j + "\t");
                }
                Console.WriteLine();
            }

        }
        static void DemoDouble()
        {


            int[,] matrix = new int[2, 3];//2d array declaration
            matrix[0, 0] = 10;//assigning values
            matrix[0, 1] = 20;
            matrix[0, 2] = 30;
            matrix[1, 0] = 40;
            matrix[1, 1] = 50;
            matrix[1, 2] = 60;
            Console.WriteLine(matrix.Length + " " + matrix.Rank);
            string[,] states = new string[,] { { "TN", "AP" }, { "TL", "KA" } };//declaration and initialition
            Console.WriteLine(states.Length + " " + states.Rank);
            int[,] arr = new int[2, 3];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Enter numbers");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            foreach (int x in arr)
            {
                Console.WriteLine(x);
            }

         
    }


static void DemoSingle()
        {
            //Console.WriteLine("Enter number of values");
            //int n = int.Parse(Console.ReadLine());
            //int[] numbers = new int[3];//declaration of array of size 3 new is used to allocate memory
            //numbers[0] = 12;
            //numbers[1] = 22;
            //numbers[2] = 100;
            //Console.WriteLine(numbers[0] + "\t" + numbers[1] + "\t" + numbers[2] + "\t");
            //numbers = new int[5];//array size is fixed..if redeclare the new array will be created
            //Console.WriteLine(numbers[0] + "\t" + numbers[1] + "\t" + numbers[2] + "\t" + numbers[3] + "\t" + numbers[4]);

            int[] arr = new int[10];//declaration
            int[] marks = { 87, 78, 90 };//dynamic allocation
            string[] names = new string[3] { "Arun", "priya", "Ram" };//declaration and initialization
            char[] alph = new char[] { 'a', '2', 'r', 'y', '#' };
            //Console.WriteLine(alph[2] + " " + names[1] + " " + marks[1]);

            arr[0] = 10;
            arr[1] = 23;
            int[] dupMarks = new int[3];
            int[] dupMarks2 = new int[3];
            //Array functions

            Console.WriteLine("Size of mark array " + marks.Length);//size of array
            Console.WriteLine("Rank of mark array " + marks.Rank);//rank or dimension
            Array.Sort(marks);//array sorting
            Console.WriteLine(marks[0] + " " + marks[1] + " " + marks[2]);
            Array.Reverse(marks);//array reversing
            Console.WriteLine(marks[0] + " " + marks[1] + " " + marks[2]);
            Array.Copy(marks, dupMarks, 2);//array copying
            Console.WriteLine(dupMarks[0] + " " + dupMarks[1]);
            Array.Copy(marks, 0, dupMarks2, 1, 2);//array copying from specified position and with count
            Console.WriteLine(dupMarks2[0] + " " + dupMarks2[1] + " " + dupMarks2[2]);

            int[] myArr = new int[10];
            //for loop is used to store value to array
            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = int.Parse(Console.ReadLine());
            }
            //for loop used for reading the content of array
            for (int i = 0; i < myArr.Length; i++)
                Console.WriteLine(myArr[i]);
            //used for iterating or reading from an array
            foreach (var x in myArr)
            {
                Console.WriteLine(x);
            }
            foreach (var x in alph)
            {
                Console.WriteLine(x);
            }
            foreach (var x in names)
            {
                Console.WriteLine(x);
            }


        }
    }
}
