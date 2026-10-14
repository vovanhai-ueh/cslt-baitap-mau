/*
 * Bài    : Buoi02_A5 – Các bẫy chia nguyên và ép kiểu
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi02_A5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            int a = 7, b = 2;
            Console.WriteLine($"1) a / b           = {a / b}");
            Console.WriteLine($"2) a % b           = {a % b}");
            Console.WriteLine($"3) (double)a / b   = {(double)a / b}");
            Console.WriteLine($"4) (double)(a / b) = {(double)(a / b)}");
            Console.WriteLine($"5) a / 2.0         = {a / 2.0}");
            double tb = (7 + 8) / 2;
            Console.WriteLine($"6) (7 + 8) / 2     = {tb}");
            Console.WriteLine($"7) (int)9.99       = {(int)9.99}");
            Console.WriteLine($"8) Math.Round(2.5) = {Math.Round(2.5)}");
            Console.WriteLine($"9) 0.1 + 0.2       = {0.1 + 0.2}");
            Console.WriteLine($"10) 1 / 0.0        = {1 / 0.0}");
        }
    }
}
