// See https://aka.ms/new-console-template for more information
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        //bai_01();
        //bai_02();
        //bai_03();
        //bai_04();
        //bai_05();
        //bai_06();
        //bai_07();
        //bai_08();
        //bai_09();
        //bai_10();
    }
    static void bai_01()
    {
        Console.WriteLine("Nhap so 1:");
        int so1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so 2:");
        int so2 = Convert.ToInt32(Console.ReadLine());
        int tong = so1 + so2;
        Console.WriteLine("ket qua la = {0} + {1}", so1, so2);
    }
    static void bai_02()
    {
        Console.Write("Nhap so 1:");
        int so3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhạp so 2:");
        int so4 = Convert.ToInt32(Console.ReadLine());
        so3 = so3 + so4;
        so4 = so3 - so4;
        so3 = so3 - so4;
    }
    static void bai_03()
    {
        Console.Write("Nhap so 1:");
        double so5 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap so 2:");
        double so6 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Tich 2 so la:" + (so5 * so6));
    }
    static void bai_04()
    {
        Console.Write("Nhap so feet:");
        double so7 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Chuyen sang meter:" + (so7 * 0.304));
    }
    static void bai_05()
    {
        Console.Write("Nhap Celsius");
        double so8 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap Fahrenheit");
        double so9 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Chuyen tu C sang F:" + (so8 * 9 / 5 + 32));
        Console.WriteLine("Chuyen tu F sang S:" + ((so9 - 32) * 5 / 9));
    }
    static void bai_06()
    {
        Console.WriteLine("Kich thuoc kieu du lieu bool:" + sizeof(bool));
        //Cac kieu tiep tuong tu nhu tren
    }
    //bai_07() khong biet lam huhu
    static void bai_08()
    {
        Console.Write("Nhap ban kinh hinh tron:");
        double so10 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Dien tich hinh tron la:" + (so10 * so10 * 3.14));
    }
   static void bai_09()
    {
        Console.Write("Nhap canh hinh vuong:");
        double so11 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Dien tich hinh vuong la" + (so11 * so11));
    }
    static void bai_10()
    {
        Console.Write("Nhap so ngay:");
        int ngay = Convert.ToInt32(Console.ReadLine());
        int nam = ngay / 365;
        int tuan = (ngay % 365) / 7;
        int ngay1 = ( (ngay % 365) % 7 );
        Console.WriteLine($"{ngay} tuong ung voi {nam} nam, {tuan} tuan, {ngay1} ngay");
    }
}


