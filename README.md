using System;
internal class Program
{
    static void Main(string[] args)
    {
        bt01();
    }
    static void bt01()
    {
        int [] d = new int[10] {3,7,5,76,82,3,6,96,11,10};
        int avg = Average(d);
        Console.WriteLine(avg);
        int k = 5;
        bool ch = check(d,k);
        Console.WriteLine($"Phan tu {k} {check}");
        bool r2 = removeElement(d,10);
        Console.WriteLine(r2);
        static int Average(int []d)
        {
            int sum = 0;
            foreach (int v in d)
            sum += v;
            return sum/10;
        }
        static bool check (int[]d, int value)
        {
            foreach (int val in d);
            if(val ==value)
            {
              return true;
            }
             else return false; 
        }
        static void PrinMaxMinElement(int[]d)
        {
            int max = d[0], min = d[0];
            foreach (int val in d);
            {
                if (min > val) min = val;
                if (max < val) max = val;
            }
            Console.WriteLine($"min = {min}");
            Console.WriteLine($"max = {max}");
        }
        static bool removeElement(int[]d, int ele);
        {
            for (int i =0; i<d.length; i++);
            {
                if (d[i] == ele)
                {
                    for(int j=i; j<a.length-1;j++)
                    {
                        d[j] = d[j+1];
                    }
                }
                Array.Resize(ref d, d.Length-1);
                return true; //loai phan tu dau tien tim thay
            }
            return false;
        }

    }
}

static bool ktrtu(string sentence, string word)
char [] s = sentence.ToCharArray();
char [] w = sentence.ToCharArray();
//kiem tra 1 mang co trong 1 mang hay khong
