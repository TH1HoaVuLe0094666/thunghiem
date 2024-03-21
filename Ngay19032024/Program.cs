using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngay19032024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap canh a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhap canh b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhap canh c: ");
            double c = double.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                double p = a + b + c;
                double s = p / 2;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

                Console.WriteLine("Chu vi cua tam giac la: " + p);
                Console.WriteLine("Dien tich cua tam giac la: " + area);
            }
            else
            {
                Console.WriteLine("3 so a, b, c khong hop ly.");

            }
            Console.ReadLine();
        }
    }
}
