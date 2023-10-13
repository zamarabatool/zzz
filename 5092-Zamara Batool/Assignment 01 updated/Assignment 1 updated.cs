using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            
             //section 1//
             //part 1//
             Console.WriteLine("Hello,World!");
             //part 2//
             Console.WriteLine("Please enter your name:");
             string Name = Console.ReadLine();
             Console.WriteLine("Hello, " + Name);
             //part 3//
             Console.WriteLine("Enter 1st number:");
             int no1 = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter 2nd number:");
             int no2 = int.Parse(Console.ReadLine());
             int sum = no1 + no2;
             Console.WriteLine("Sum =" + sum);
             //part 4//
             Console.WriteLine("Enter the number:");
             int no = int.Parse(Console.ReadLine());
             Console.WriteLine("The square of " + no + " is = " + no * no);
             //part 5//
             for (int i = 0; i <= 100; i++)
                 if (i % 2 == 0)
                     Console.WriteLine(i);
             //section 2//
             //part 6//
             int sumnum_ = 0;
             Console.WriteLine("Enter the number:");
             int sumnum = int.Parse(Console.ReadLine());
             for (int i = 1; i <= sumnum; i++)
                 sumnum_ = sumnum_ + i;
             Console.WriteLine("The sum of all numbers till " + sumnum + " is: " + sumnum_);
             //part 7//
             Console.WriteLine("Enter the number:");
             int tableno=int.Parse(Console.ReadLine());
             for (int i = 1; i <= 12; i++)
                     Console.WriteLine(tableno + " X " + i + " = " + i * tableno);
             //part 8//
             bool isaprimeno = true;
             Console.WriteLine("Enter the number:");
             int primeno = int.Parse(Console.ReadLine());
             for (int i = 2; i <= primeno; i++)
             {

                 for (int j = 2; j < i; j++)
                 {
                     if (i % j == 0)
                         isaprimeno = false;
                     break;

                 }
                 if (isaprimeno == true)
                     Console.WriteLine(i);
                 isaprimeno = true;
             }
             //part 9//
             int factnum_ = 1;
             Console.WriteLine("Enter the number:");
             int factnum = int.Parse(Console.ReadLine());
             for (int i = 1; i <= factnum; i++)
                 factnum_ = factnum_ * i;
             Console.WriteLine(factnum + "! = " + factnum_);
             //part 10//
             int x = 0;
             int y = 1;
             Console.WriteLine("Enter the number of terms of seies:");
            
             int fabnum = int.Parse(Console.ReadLine());
           
             for (int i = 0; i < fabnum; i++)
             {
                 Console.WriteLine(x);
               
                 int z = x;
                 x = y;
                 y = z + y;
             }
             //Section 3//
             //part 11//
             Console.WriteLine("Write the number: ");
             int n = int.Parse(Console.ReadLine());
             int[] Array = { 1, 3, 5, 7, 9 };
             int x = 0;
             foreach (int i in Array)
             {
                 if (i == n)
                     x = x + 1;

                 else
                     x = x + 0;
             }
             if (x > 0)
                 Console.WriteLine("This number is in the array");
             else
                 Console.WriteLine("This number is not in the array");
             Console.WriteLine("Write the number: ");
              int n= int.Parse(Console.ReadLine());
              int[] Array = { 1, 3, 5, 7, 9 };
              int x = 0;
              foreach(int i in Array)
              {
                  if (i == n)
                      x = x + 1;

                  else
                      x = x + 0;
              }
              if (x > 0)
                  Console.WriteLine("This number is in the array");
              else
                  Console.WriteLine("This number is not in the array");
             //part 12//
             Console.WriteLine("Write the word: ");
             string word = (Console.ReadLine());
             string rev = "";
             for (int i = word.Length - 1; i >= 0; i--) 
             {
                 rev = rev + word[i];
             }
             if (word == rev)
                 Console.WriteLine("This word is palindrome");
             else
                 Console.WriteLine("This word is not a palindrome");
             //part 13//
             int[] Aray_ = { 10, 9, 5, 3, 2 };
             //int[] x = { Array.Sort(Aray_) };//
             Array.Sort(Aray_);
             int[] x = Aray_;
             Console.WriteLine("smallest number= "+x[0]);
             Console.WriteLine("largest number= " + x[x.Length-1]);
            //part 14//
            Console.WriteLine("Write the height: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("");
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
            }


            Console.ReadKey();
        }
    }
}
