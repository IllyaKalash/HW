using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    internal class Program
    {

        static void task_10(string[] args)
        {
            int b = 0;
            int a = Convert.ToInt32(Console.ReadLine());
            while (a != 0)
            {
                b = a % 10;
                a /= 10;
                if (b % 2 != 0)
                {
                    Console.WriteLine(b);
                }
            }
        }
        static void task_9(string[] args)
        {
            int b=0;
            int a = Convert.ToInt32(Console.ReadLine());
            while (a != 0)
            {
                b = a % 10;
                a /= 10;
                if (b % 2 != 0)
                {
                    Console.WriteLine(b);
                }
            }
        }
        static void task_6(string[] args)
        {
            int a = 1;
            int b = 1;
            int c=a+b;
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i < n; i++)
            {
                b = a;
                a = c;
                c = a + b;
            }
            Console.WriteLine($"{a}+{b}={c}");
        }
        static void task_7(string[] args)
            {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            while ((a != 0) && (b != 0))
                {
                    if (a > b)
                        a -= b;
                    else
                        b -= a;
                }
            Console.WriteLine(a+b);
            }
        
        static void task_5(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            if (a > b)
            {
                int d = a;
                int e = b;
                for (int i = e; i < d; i++)
                {
                    c = c + i;
                    if (c < d && c % 7 == 0)
                    {
                        Console.WriteLine(c);
                    }
                }
            }
            else
            {
                for(int i = a; i<b; i++)
                {
                    c=c+ i;
                    if (c<b && c % 7 == 0)
                    {
                        Console.WriteLine(c);
                    }
                }
            }
        }
        static void task_4(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i = a/2; i>=1; i--)
            {
                if (a % i == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
        static void task_3(string[] args)
        {
            int A = 1;
            int a = 200;
           for(int i=0; i*i<a; i++)
            {
                Console.WriteLine(i);  
            }
        }
        static void task_2(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<1000; i++)
            {
                if( i%a == 0)
                {
                    Console.WriteLine(i);   
                }
            }
        }
        static void task_1(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int C = a;
            for (int i = 1; i < b; i++)
            {
                C = C * a;
            }
            Console.WriteLine(C);
        }

        static void Main(string[] args)
        {
            
            //task_9(args);
            //task_7(args);
            //task_6(args);
            //task_5(args);
            //task_4(args);
            //task_3(args);
            //task_2(args);
            //task_1(args);

        }
    }
}
