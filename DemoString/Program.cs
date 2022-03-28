using System;

namespace DemoString
{
    class Program
    {
        static void Main(string[] args)
        {/*
            string str = "welcome";
            Console.WriteLine(str);
            Console.WriteLine(str + " To C#");
            Console.WriteLine(str);//string is immutable even if we add string the size will not change .it will remin same
            str = str + "c#";
            Console.WriteLine(str);
            //string copy
            string str1 = "Hello";
            string str2 = "welcome";
            string str3 = string.Copy(str2);//copying to a new instance
            Console.WriteLine(str3);
            char[] strnew = str2.ToCharArray();
            str1.CopyTo(1, strnew, 4, 2);//copying a range from source to destination
            Console.WriteLine(str1);
            Console.WriteLine(strnew);

            //concat 2 strings
            string strconCat = string.Concat(str1," ", str2);
            Console.WriteLine(strconCat);
           // Console.WriteLine(str1.Concat(str2));//it will not work as string immutable
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            */

            //String comparison
            /* string str1 = "hello";
              string str2 = "Hello";
              int n = string.Compare(str2, str1);
              Console.WriteLine(n);
              n = string.Compare(str2, str1, StringComparison.InvariantCultureIgnoreCase);//2 string comparison
              Console.WriteLine(n);
              if (string.Compare(str2, str1) == 0) Console.WriteLine("Both strings are same");
              n = string.Compare("Chennai", 3, "anN", 1, 2, StringComparison.InvariantCultureIgnoreCase);//range comparison
              Console.WriteLine(n);

              //string equals
              string myString1 = "hello";
              string myString2 = "Hello";
              if (myString1 == myString2) Console.WriteLine("Strings are same");
              else Console.WriteLine("Strings are not same");
              if (myString1.Equals(myString2, StringComparison.InvariantCultureIgnoreCase))//equals used to simple cchecking and case sensitivity checking
                  Console.WriteLine("Strings are same");
              else Console.WriteLine("Strings are not same");*/

            //split function

            Console.WriteLine("Enter the names of candidates");
            string s = Console.ReadLine();
            Console.WriteLine(s);
            string[] names = s.Split('/');
            foreach (string x in names)
                Console.WriteLine(x);
            Console.WriteLine(s);

            Console.WriteLine("Enter the numbers");
            s = Console.ReadLine();
            Console.WriteLine(s);
            string[] numbers = s.Split('.');
            int[] num = new int[numbers.Length];
            int i = 0;
            foreach (string x in numbers)
            {


                num[i] = Convert.ToInt32(x);
                i++;
            }

            foreach (int x in num)
            {


                Console.WriteLine(x);
            }
            string s3 = string.Join("- ", "abc", "efg", "uii", "kloiu");
            Console.WriteLine(s3);
            //string functions
            string sl = "welcome";
            Console.WriteLine(sl.LastIndexOf('e'));
            Console.WriteLine(sl.IndexOf("come"));
            Console.WriteLine(sl.Contains("me"));
            Console.WriteLine(sl.ToLower() + "  " + sl.ToUpper());
            Console.WriteLine(sl.Substring(2));
            Console.WriteLine(sl.Substring(2, 3));
            Console.WriteLine(sl.Replace('c', 's'));
            Console.WriteLine(sl.Replace("come", "go"));
            Console.WriteLine(sl.Remove(3));
            Console.WriteLine(sl);
            Console.WriteLine(sl.Remove(3, 2));
            Console.WriteLine(sl);

        }
    }
}
