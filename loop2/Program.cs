using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //7..print the fibonacci series number of digit in o/p 7
            //0 1 1 2 3 5 8
            int n, n1 = 0, n2 = 1, n3;
            Console.WriteLine("enter the upper limit");
            n=Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine($" {n1} {n2}");

            for (int i = 2; i < n; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine($"{n3}");
                n1 = n2;
                n2 = n3;
            }
            

            // 6..acceept the numbers from users find the factorial

            //Console.WriteLine(" enter the numbers");
            //int num=Convert.ToInt32(Console.ReadLine());
            //int fact = 1;
            //for (int i=1; i<=num; i++)
            //{
            //  fact = fact*i;
            //}
            //Console.WriteLine(fact);

            ////print the numbers i=100 which are divisible by 5

            //for(int i=1; i<=100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


          //Console.WriteLine("enter the number");
            //int num=Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <=10; i++)
            //{
            //    Console.WriteLine($"{num} * {1}={num*i}");
            //}

                    
            //for (int i =100; i>=50;i--)
            //{
            //    if(i%2!=0)
            //        Console.WriteLine(i);
            //}


            //for (int i = 1; i <= 20; i++) 
            //{
            //    if(i % 2==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
        }
    }
}
