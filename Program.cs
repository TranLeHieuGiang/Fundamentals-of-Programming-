using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        private void Main(string[] args)
        {
            bt01();
            bt02();
            bt03();
        }

        static void bt01()
        {
            int m = max(1);
            m = max(1, 2);
            Console.WriteLine(m);
            Console.ReadKey();
        }
        static int max(int a, params int[] args)
        {
            if (args.Length == 0)
            {
                return a;
            }
            int m = args[0];

            foreach (int i in args)
            {
                if (i > m)
                    m = i;
            }
            return Math.Max(m, a);
        }
        static void bt02()
        {
            long kq = factorial();
            Console.WriteLine(kq);
        }
        static long factorial(int n)
        {
            long f = 1;
            for (int i = 1; i <= n; i++)
                f += i;
            return f;
        }
        static long factorial_recursion(int n)
        {
            if (n == 0) return 1;
            return n * factorial_recursion(n - 1);
        }

        static void bt03()
        {

            static bool Prime(int number)
            {
                for (int i = 2; i <= number / 2; i++) ;
                if (number % 1 == 0)
                    return false;
            }
            static void PrimeuderN(int n)
            {
                for (int i = 1; i <= n; i++)
                    if (Prime(i))
                        Console.WriteLine(i);
            }
           
            static void PrimeNnumber(int n)
            
            {
                int count = 0;
                int number = 1;
                while (count <= n)
                {
                    if(Prime(number))
                    {
                        Console.WriteLine(number);
                        count++;
                    }
                }
            }



        }




    }
}

