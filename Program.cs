using System;
internal class Program
{
    static void Main(string[] args)
    {
        bt01();
        bt02();

    }

    static void bt01()
    {
        int[][] mang1 = new int[4][]
        {
            new int [] {1, 1, 1,1},
            new int [] {2,2},
            new int [] {3,3,3,3},
            new int [] {4,4},
        };
        for (int i = 0; i < mang1.Length; i++)
        {
            for (int j = 0; j < mang1[i].Length; j++)
                Console.Write(mang1[i][j] + " ");
            Console.WriteLine();
        }
    }

    //bt02
    static void Print(int[][] a)
    {
        foreach (int[] rows in a)
        {
            foreach (int i in rows)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

    }
    static void bt02()
    {
        Console.Write("Nhap vao so hang: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[rows][];
        Random rnd = new Random();
        for (int i = 0; i < rows; i++)
        {
            Console.Write("Nhap vao hang: ");
            int cols = Convert.ToInt32(Console.ReadLine());
            a[i] = new int[cols];
            for (int j = 0; j < cols; j++)
                a[i][j] = rnd.Next(30, 50);
        }

        Print(a);
        FindMax(a);
        sort_row(a);

        Console.WriteLine();
        print_prime(a);
        int k = Convert.ToInt32(Console.ReadLine());
        

    }
    static void FindMax(int[][] a)
    {
        foreach (int[] rows in a)
        {

        }

    }
    static void sort_row(int[][] a)
    {
        for (int i = 0; i < a.Length; i++)
            sort(a[i]);
        foreach (int[] rows in a)
        {
            foreach (int i in rows)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

    }

    static void sort(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
            for (int j = 0; j < a.Length; j++)
            {
                if (a[i] > a[j])
                {
                    int doi = a[i];
                    a[i] = a[j];
                    a[j] = doi;
                }
            }
        foreach (int m in a)
        {
            Console.Write($"{m} ");
        }
    }


    static void print_prime(int[][] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a[i].Length; j++)
                if (Prime(a[i][j]))
                    Console.WriteLine($"{a[i][j]} xuat hien o hang {i} va cot {j} ");
        }
        static bool Prime(int nua)
        {
            for (int i = 2; i < nua / 2; i++)
            {
                if (nua % i == 0)
                    return false;

            }
            return true;
        }
        TimSo(a,76);
        static void TimSo(int[][] a, int value)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                   if ((a[i][j]) == value)
                    Console.WriteLine($"{a[i][j]} xuat hien o hang {i} va cot {j} ");
                }
            }

           


            
        }
    }
}