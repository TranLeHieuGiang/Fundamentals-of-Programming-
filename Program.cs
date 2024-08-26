
using System;
using System.ComponentModel.Design;
internal class Program
{
    private static void Main(string[] args)
    {
        //Nguoi choi co tien;
        Console.WriteLine("Nguoi choi co 1000$ lun nhoe");
        do
        {
            //Nguoi choi bat dau choi;
            Random rnd = new Random();
            int com_num = rnd.Next(1, 100);
            //Console.WriteLine(com_num);
            int man_num = 0;

            for (int i = 0; i < 10; i++)
            {
                    Console.Write("Nhap so doan: ");
                    man_num = Convert.ToInt32(Console.ReadLine());
                    if (man_num == com_num)
                    {
                        Console.Write("Gioi qua gioi qua ~~");
                        break;
                    }
                    else
                       if (man_num < com_num)
                        Console.WriteLine("So cua ban nho hon so voi dap an. ");
                    else Console.WriteLine("So cua ban lon hon so voi dap an. ");
            }
            if (man_num != com_num) 
            Console.WriteLine($"So cua ban la {man_num} nhung dap an la {com_num}. Rat tiec huhu :((( ");
            
            Console.WriteLine("Ban co con mun tip tuc cung chung toi? Y/N");
            Console.WriteLine();
            string trl = "" + Console.ReadLine();
            if (trl.ToUpper().Equals(("Y"))) ;
            {  
                int solan = Convert.ToInt32(trl);
                solan++;
                Console.WriteLine("Ban da nap them 50$ de choi tiep ");
                break;
            }
            
            //Console.WriteLine("Ban da choi va con lai ");
            //Console.WriteLine("Hen gap lai ^^ ");
        } while (true);    
    }
    
}
