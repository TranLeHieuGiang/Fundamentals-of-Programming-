using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap vao chuoi sau: ");
        string[] s = new string[100];
        bt01(s);
        bt02(s);
        bt03(s);
        bt04(s);
        bt05(s);
        bt06(s);
        bt07(s);
    }
    static void bt01(string[] s)
    {
        
        Console.WriteLine(s);
    }
    static void bt02(string[] s)
    {
        
        int count = 0;
        
        {
            count = 1;
        }
        while (count <s.Length)
        {
           
        }
        {

            count++;
        }

        Console.WriteLine($"Do dai chuoi la: {count}");
    }
    static void bt03(string[] s)
    {
        foreach (string v in s)
        {
            Console.Write($" {v} ");
        }
        Console.WriteLine();
    }
    static void bt04(string[] s)
    {
       
        for (int i = s.Length - 1; i >= 0; i--)
        {
            Console.Write(s[i] + " "); 
        }
        Console.WriteLine();
    }
    static void bt05(string[] s)    
    {
        
    }
   static void bt06(string[] s)
    {
        Console.Write("Nhap vao chuoi 1: ");
        string s3 = Console.ReadLine();

        if (s3.Length > s.Length)
            Console.WriteLine($"Chuoi dai hon la: {s3}");
        else Console.WriteLine($"Chuoi dai hon la: {s}");
    }
    static int bt07(string[] s)
    {
        int[] a = new int[3];
        int c = 0, v = 0, d = 0;

        foreach (int i in a)
        {
            if ((i >= 'a' && i <= 'z') || (c >= 'A' && c <= 'Z'))

            {
                c++;
            }
            if (c >= 0 && c <= 9)
                v++;
            else d++;
        }
        a[0] = c;
        a[1] = v;
        a[2] = d;
        return 0;
        Console.WriteLine();
    }
}