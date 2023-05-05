using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            // Task2();
            // Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task8();
            //Task9();
            //Task10Login();
            Task11();
            // Task12FileHandling();
            //Task13Probability();
            Console.SetCursorPosition(19, 0);
            Console.ReadKey();
        
        }
        static void Task1()
        {
            int age;
            int toyPrice, evenAmmount = 0, oddAmmount = 0, NumberOfToy = 0, totalGot, totalAfterLilly, machinePrice;
            Console.WriteLine("Enter Lillay age");
            age = int.Parse(Console.ReadLine());
            int m = 1;
            for (int x = 0; x < age; x++)
            {
                if (x % 2 == 0)
                {
                    evenAmmount = evenAmmount + m * 10;
                    m++;
                    evenAmmount--;
                }
                if (x % 2 != 0)
                {
                    NumberOfToy++;
                }

            }

            Console.WriteLine("Enter Toy Price:");
            toyPrice = int.Parse(Console.ReadLine());
            oddAmmount = toyPrice * NumberOfToy;
            totalGot = evenAmmount + oddAmmount;
            Console.WriteLine("Enter Washing Machine Price:");
            machinePrice = int.Parse(Console.ReadLine());

            if (machinePrice > totalGot)
            {
                Console.WriteLine("No ! " + totalGot);
            }
            if (machinePrice < totalGot)
            {
                Console.WriteLine("Yes ! " + (totalGot - machinePrice));
            }

            Console.ReadKey();


        }
        static void Task2()
        {
            int integer = 5;
            float floatingN = 9.99F;
            Double FloatIngMorePrecise = 12.22222D;
            string str = " I am Programmer!";
            long LongInteger = 3333484848848848484L;
            char myGrade = 'B';
            bool Check = true;

            Console.WriteLine("integer :" + integer);
            Console.WriteLine("Float :" + floatingN);
            Console.WriteLine("DoubleFloating:" + FloatIngMorePrecise);
            Console.WriteLine("String:" + str);
            Console.WriteLine("LongInteger :" + LongInteger);
            Console.WriteLine("Character:" + myGrade);
            Console.WriteLine("Bool:" + Check);
            Console.ReadKey();






        }
        static void Task3()
        {
            string str;
            float floating;
            int integer;
            char character;

            Console.WriteLine("Enter String:");
            str = Console.ReadLine();
            Console.WriteLine("Enter Flaoting Number:");
            floating = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter an Integer:");
            integer = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Character:");
            character = char.Parse(Console.ReadLine());
            Console.ReadKey();


        }
        static void Task4()
        {
            int lenght, Area;
            Console.WriteLine("Enter Length");
            lenght = int.Parse(Console.ReadLine());
            Area = lenght * lenght;
            Console.WriteLine("Area is:" + Area);
            Console.ReadKey();


        }
        static void Task5()
        {
            int marks;
            Console.WriteLine("Enter MArks:");
            marks = int.Parse(Console.ReadLine());
            if(marks > 50)
            {
                Console.WriteLine("Passed");
            }
            else if(marks <= 50)
            {
                Console.WriteLine("Failed");
            }

            Console.ReadKey();


        }
       static void Task6()
        {
            int sum = 0;
            int  num;
            do
            {
                Console.WriteLine("Enter Number:");
                num = int.Parse(Console.ReadLine());
                sum = sum + num ;
            }
            while (num != -1);
            sum++;
            Console.WriteLine("Sum is:" + sum);
            Console.ReadKey();
        }
        static void Task7()
        {
            int[] arr = new int[3];
            for (int x = 0; x < 3; x++)
            {
                Console.WriteLine("Enter Number {0}", x);
                arr[x] = int.Parse(Console.ReadLine());
            }
            int largest = -1;
            //Finding largest
            for (int x = 0; x < 3; x++)
            {
                if (arr[x] > largest)
                {
                    largest = arr[x];
                }

            }

            Console.WriteLine("Largest is: {0} ", largest);
            Console.ReadKey();
        }
        static void Task8()
        {
            string path = "E:\\Objects Oriented Programming Lectures\\textFile.txt";
            if(File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                    {
                    Console.WriteLine(record);
}

            }
            else
            {
                Console.WriteLine("Not Exist");
            }
            Console.ReadKey();



        }
        static void Task9()
        {
            string path = "E:\\Objects Oriented Programming Lectures\\textFile.txt";
            StreamWriter writeNow = new StreamWriter(path, true);
            writeNow.WriteLine("I am on Route of Becoming a Good Programmer ! Alhumdillah");
            writeNow.Flush();
            writeNow.Close();

        }
        static void Task10Login()
        {
            string path = "E:\\Objects Oriented Programming Lectures\\textFile.txt";
            string[] names = new string[5];
            string[] passwords = new string[5];
            int options;
            do
            {
                readData(path, names, passwords);
                Console.Clear();
                options = menu();
                Console.Clear();
                if (options == 1)
                {
                    Console.WriteLine("Enter name:");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter Password:");
                    string p = Console.ReadLine();
                    signIn(n, p, names, passwords);
                }
                else if (options == 2)
                {

                    Console.WriteLine("Enter name:");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter Password:");
                    string p = Console.ReadLine();
                    signUp(path, n, p);
                }

            }
            while (options < 3);
            Console.ReadKey();

        }
        static int menu()
        {
            int options;
            Console.WriteLine("1.Sign IN>>");
            Console.WriteLine("2.Sign UP>>");
            Console.WriteLine("Enter option:");
            options = int.Parse(Console.ReadLine());
            return options;

        }
        static string ParseData(string record,int field)
        {
            int commaCount = 1;
            string item = "";
            for(int x=0;x<record.Length;x++)
            {
                if(record[x] == ',')
                {
                    commaCount++;
                }
                else if(commaCount == field)
                {
                    item = item + record[x];
                }
            }
            return item;

        }
        static void readData(string path,string[] names,string[] password)
        {
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader readIt = new StreamReader(path);
                string record;
                while ((record = readIt.ReadLine()) != null)
                {
                    names[x] = ParseData(record, 1);
                    password[x] = ParseData(record, 2);
                    x++;
                    if (x >= 5)
                    {
                        break;
                    }
                }
                readIt.Close();
            }
            else
            {
                Console.WriteLine("Not exist");
            }


        }
        static void signIn(string n,string p , string[] names,string[] password)
        {
            bool flag = false;
            for(int x=0;x<5;x++)
            {
                if(n == names[x] && p == password[x])
                {
                    Console.WriteLine("Valid User");
                    flag = true;
                }
            }
            if(flag == false)
            {
                Console.WriteLine("InValid User");
            }
            Console.ReadKey();
        }
        static void signUp(string path,string n,string p)
        {
            StreamWriter writer = new StreamWriter(path);
            writer.WriteLine(n + "," + p);
            writer.Flush();
            writer.Close();
        }
        static void Task11()
        {

           int[,] cars = {
 { 10, 7, 12, 10, 4},
 { 18, 11, 15, 17, 2},
 { 23, 19, 12, 16, 14},
 { 7, 12, 16, 0, 2},
 { 3, 5, 6, 2, 1}
 };
            int sum = 0;
            for(int x=0;x<5;x++)
            {
                for(int y=0;y<5;y++)
                {
                    sum = sum + cars[x, y];
                    Console.Write(cars[y, x] +" ");
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine("Sum Of All Colors of Cars is:{0}", sum);
            Console.WriteLine();
        }
        static void Task12FileHandling()
        {
            string[] Names = new string[2];
            string[] NumberOfOrders = new string[2];
            string[] Orders = new string[2];
            string path = "E:\\OOP\\data.txt";
            string line = "";
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader record = new StreamReader(path);
                while((line = record.ReadLine()) != null)
                {
                    Console.WriteLine(Names[x] = spaceCount(line, 1));
                    Console.WriteLine(NumberOfOrders[x] = spaceCount(line, 2));
                    Console.WriteLine(Orders[x] = spaceCount(line, 3));
                    x++;
                }
            }
            else
            {
                Console.WriteLine("File Not Exist");
            }
            int[] number = new int[2];
             number[0] = int.Parse(NumberOfOrders[0]);
             number[1] = int.Parse(NumberOfOrders[1]);
            int[] data1 = new int[20];
            int[] data2 = new int[20];
            Splitter(Orders,number,ref data1,ref data2);
            /*for(int idx=0;idx < number[0];idx++)
             {
                 Console.WriteLine(data1[idx]);
             }
             for (int idx = 0; idx < number[1]; idx++)
             {
                 Console.WriteLine(data2[idx]);
             }*/
            int NUMBEROFORDERS,MINIUMORDERPRICE;
            Console.WriteLine("Pizza Points:");
            Console.WriteLine("Enter Minium Number Of Orders:");
            NUMBEROFORDERS = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Minium Order Price:");
            MINIUMORDERPRICE = int.Parse(Console.ReadLine());
            CheckAvailability(NUMBEROFORDERS,MINIUMORDERPRICE,data1,data2,Names,Orders,number);









           
        }
        static string spaceCount(string record,int field)
        {
            int SpaceCounter = 1;
            string item = "";
            for(int x=0;x<record.Length;x++)
            {
                if(record[x] == ' ')
                {
                    SpaceCounter++;
                }
                else if(SpaceCounter == field)
                {
                    if(record[x] !='[' && record[x] != ']')
                    { 
                    item = item + record[x];
                    }
                }


            }
            return item;


        }
        static string OrdersReader(string order, int field)
        {
            
            int commaCount = 0;
            string item = "";
            for (int x = 0; x < order.Length; x++)
            {
                if (order[x] == ',')
                {
                    commaCount++;
                }
                else if (commaCount == field)
                {
                  
                        item = item + order[x];
                    
                }
            }
            return item;
        }

        static void Splitter(string[] Orders,int[] number,ref int[] data1,ref int[] data2)
        {
            string collect = Orders[0];
            string collect2 = Orders[1];
            for (int idx = 0; idx<number[0] ; idx++)
            {

                data1[idx] = int.Parse(OrdersReader(collect, idx));

            }
            for (int idx = 0; idx < number[1]; idx++)
            {
                data2[idx] = int.Parse(OrdersReader(collect2, idx));

            }
            

        }
        static void CheckAvailability(int NUMBEROFORDERS,int MINIUMORDERPRICE,int[] data1,int[] data2,string[] names,string[] Orders,int[] number)
        {
            int counter1 = 0;
            int counter2 = 0;
            for (int idx =0; idx <number[1];idx++)
            {
                if(data1[idx] >= MINIUMORDERPRICE  )
                {
                    counter1++;
                }
                if(data2[idx] >= MINIUMORDERPRICE )
                {
                    counter2++;
                }
            }


            if(counter1 >= NUMBEROFORDERS)
            {
               
                Console.WriteLine(names[0]);
            }
             if(counter2 >= NUMBEROFORDERS )
            {
               
                Console.WriteLine(names[1]);
            }
             if(counter1 < NUMBEROFORDERS && counter2 < NUMBEROFORDERS)
            {
                Console.WriteLine("null");
            }

        }
        static void Task13Probability()
        {


        }
    }
}
