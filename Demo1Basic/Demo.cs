using System;
using static System.Console;
namespace Demo1Basic
{
    class Demo
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //WriteLine("Hi this is to console");
            //WriteLine(args[0]);

            //int,float,double,decimal,short,long,byte,bool,sbyte,uint,ushort,ulong,datetime
            //userdefined:enum,struct,class
            //int id = 234;
            //string name = "CTS";
            //WriteLine("id is " + id);//string concatenation
            //WriteLine("id is  {0} name is {1}" , id,name);//string position indexing
            //WriteLine($"id is  {id} name is {name}");//string interpolation

            //datatype varaiablename;
            //bool status;//declaration;
            //status = true;//initialization
            //bool accept = false;//declaration and initialization

            ////character build in data types declaration initialization
            //char chr = 'g';

            ////Integer build in data types declaration initialization
            //int mark = 10;
            //byte count = 100;
            //long amount = 123456789;
            //short id = 2345;
            //sbyte num = 127;
            //uint ip = 234;
            //ulong cnt = 12345577;

            ////Decimal datatypes declaration initialization
            //float height = 12.56789432f;
            //double price = 234.567897623;
            //decimal dec = 234.678965432m;

            ////displaying variable values
            //WriteLine(" Character variable");
            //WriteLine(chr);
            //WriteLine(" Integer variables");
            //WriteLine("Integer {0}  ", mark);//by using position indexing
            //WriteLine("Integer  " + mark);//string concatenation
            //WriteLine($" Integer {mark}");//string interpolation
            //WriteLine(mark);
            ////displaying variable values to the console in different ways
            //WriteLine("byte {0} long {1} short {2} sbyte {3} uint {4} ulong {5}", count, amount, id, num, ip, cnt);
            //WriteLine("byte " + count + " long " + amount + " short " + id + " sbyte " + num + " uint " + ip + " ulong" + cnt);
            //WriteLine($"byte {count} long {amount} short {id} sbyte {num} uint {ip} ulong {cnt}");

            //WriteLine($" float {height} {sizeof(float)} {float.MaxValue}\n double {price}  {sizeof(double)} \n decimal {dec}   {sizeof(decimal)}");

            //VAR,DYNAMIC OBJECT datatpes
            //var price=34;
            //WriteLine(price);
            //var amount = 78.93f;
            //WriteLine(amount);
            ////implicit type casting
            //amount = 90;
            //WriteLine($"after type casting {amount}");
            ////explicit type casting
            //price =(int) 23.45f;

            //WriteLine($"after type casting {price}");
            //dynamic age;
            //age = 12;


            //WriteLine($"dynamic {age}");
            //age = "twelve";
            //WriteLine($"dynamic {age}");
            //age=45.67f;
            //WriteLine($"dynamic {age}");
            //object is the base type of any data types
            //when we store a value type  to object  means converted to reference type that is called boxing
            //the below shows the concept of boxing
            ////boxing is implicit process
            //int num = 10;
            //object obj = num;
            //WriteLine($"object {obj}");
            //obj = "welcome";

            //WriteLine($"object {obj}");
            //obj = 45.67f;
            //WriteLine($"object {obj}");
            ////the below reverse of boxing where reference type converted to value type
            ////unboxing is explicit process
            //obj = 89;
            //int i =(int) obj;

            //WriteLine($"i {i}");
            //obj = 45.67f;
            //float fl = (float)obj;

            Console.WriteLine("enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("enter your Age");
            //int age = Convert.ToInt32(Console.ReadLine());

           float age = float.Parse(Console.ReadLine());


        }
    }
}
