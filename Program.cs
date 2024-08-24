// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Xml;
internal class Program
{
    private static void Main(string[] args)
    {
        bt01();
        bt02();
        bt03();
        bt04();
        bt05();
    }
    static void bt01()
    {
        Console.Write("Nhap vao do C:");
        float c = Convert.ToSingle(Console.ReadLine());
        float doF = (c * 18 / 10) + 32;
        float doK = c + 273;
        Console.WriteLine($"Do {c} tuong duong voi {doK} do F va {doF} do F");
    }
    static void bt02()
    {
        Console.Write("Nhap ban kinh hinh cau:");
        float r = Convert.ToSingle(Console.ReadLine());
        double pi = Math.PI;
        double surface = 4* pi*Math.Pow(pi, 2);
        double volume = 4/3 * pi * Math.Pow(pi, 3);
        Console.WriteLine($"Surface va Volume cua hinh cau lan luot la {surface} va {volume}");
    }
    static void bt03()
    {
        Console.Write("Nhap so 1 vao:");
        int a1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap so 2 vao:");
        int a2 = Convert.ToInt32(Console.ReadLine());
        int tong = a1 + a2;
        int hieu = a1 - a2;
        int tich = a1 * a2;
        int thuong = a1 / a2;
        Console.WriteLine($"cac phep tinh la: {tong},{hieu},{tich},{thuong}");
    }
    static void bt04()
    {
        Console.Write("Nhap vao chuoi sau: ");
        string text = Console.ReadLine();
        Console.WriteLine(text);
    }
    static void bt05()
    {
        Console.Write("Nhap vao chuoi sau");
        string text = Convert.ToString(Console.ReadLine());
        int length = text.Length;
        Console.WriteLine($"Do dai chuoi la: {length}");
    }

}