/*
 * Bài    : Buoi02_B3 – Khoảng cách giữa hai điểm
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi02_B3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("x1 = "); double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1 = "); double y1 = double.Parse(Console.ReadLine());
            Console.Write("x2 = "); double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2 = "); double y2 = double.Parse(Console.ReadLine());
            double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"AB = {d:F2}");
        }
    }
}
