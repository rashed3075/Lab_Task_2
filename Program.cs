using System;
using System.Globalization;

namespace Lab_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int i;
            Console.WriteLine("Even Numbers are : ");
            for( i=1;i<=n;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine (i);
                }
            }

            int key = 0;
            int core = 0;
            for( i = 1; i <=100; i++)
            {
                if(i%2==0)
                {
                    key=key+i;
                    
                }
                else
                {
                    core = core + i;
                    
                }
            }
            Console.WriteLine("Sum of all even number is : " + key);
            Console.WriteLine("Sum of all odd number is : " + core);


            int fact = 1;
            for(i=1;i<=5;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial result : " + fact);
            int j;
            Console.WriteLine();

            for(i=0;i<4;i++)
            {
                for(j=0;j<6;j++)
                {
                    if (i%2==0)
                    {
                        if(j%2==0)
                        {
                            Console.Write("X");

                        }
                        else
                        {
                            Console.Write("0");
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("0");

                        }
                        else
                        {
                            Console.Write("X");
                        }
                    }
                }
                Console.WriteLine();
            }
            
        }
    }
}
