using System;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("10 day so fibonacci: ");
            for (i = 1; i < 13; i++) 
            {
                Console.Write(" {0} \t", fibonacci(i));
            }
            Console.WriteLine();
            Console.ReadKey();


        }
        static int fibonacci(int n)
        {
            int f0 = 0;
            int f1 = 1;
            int fn = 1;
            int i;
            if (n < 0)
            {
                return -1;
            }
            else if (n == 0 || n == 10)
            {
                return n;
            }
            else
            {
                for (i = 2; i < n; i++)
                {
                    f0 = f1;
                    f1 = fn;
                    fn = f0 + f1;
                }
                return fn;
            }
        }
    }

}
