// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System;
internal class Program
{
    public static void Main(string[] args)
    {
        bt01();
        bt02();
    }
        static void bt01()
        {
            Console.Write("Nhap do C");
            float a1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Chuyen sang do F:" + ((a1 * 18 / 10) + 32));
            Console.WriteLine(("Chuyen sang do K:" + (a1 + 273)));
        }
        static void bt02()
        {
            Console.Write("Nhap ban kinh hinh cau");
            float r1 = Convert.ToSingle(Console.ReadLine());
            double pi = Math.PI;
            Console.WriteLine("Dien tich hinh cau:" + (Math.Pow(r1,2) * pi * 4));
            Console.WriteLine("The tich hinh cau:" + (4 / 3 * Math.Pow(r1,3) * pi));
        }
}
