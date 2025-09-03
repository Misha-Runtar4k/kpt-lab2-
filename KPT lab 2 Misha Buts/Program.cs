using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPT_lab_2_Misha_Buts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            long b;
            byte c;
            Console.WriteLine("Enter a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter c:");
            c = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Result : " + (a - b + c));
            Console.WriteLine("Result : " + (a + b + c));
            Console.WriteLine("Result : " + (a - (b - c)));
                }
    }
}
