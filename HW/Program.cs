using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    internal class Program
    {
        static void task_4(string[] args)
        {
            int a = 10;
            for (int i = a/4; i < a / 2; i++)
            {
                if (% i == 0)
                {

                }
            }

        }
        static void task_3(string[] args)
        {
            
            int a = 200;
           for(int i=0; i*i<a; i++)
            {
                Console.WriteLine(i);
                
            }

        }
        static void task_2(string[] args)
        {
            int a = 24;
            for(int i=1; i<1000; i++)
            {
                double b =i/a ;
                if( b == 0)
                {
                    Console.WriteLine(i);   
                }
                else
                {
                    Console.WriteLine("no");
                }
            }

        }

        static void task_1(string[] args)
        {
            int a = 8;
            int b = 3;
            int C = a;
            for (int i = 1; i < b; i++)
            {

                C = C * a;

            }
            Console.WriteLine(C);


        }

        static void Main(string[] args)
        {
             //task_3(args);
            
           //task_1(args);

        }
    }
}
