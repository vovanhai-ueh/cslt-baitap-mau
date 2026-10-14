/*
 * Bài    : Buoi02_B1 – Đổi nhiệt độ
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi02_B1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Nhập nhiệt độ C: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine($"{c} C = {c * 9 / 5 + 32:F2} F = {c + 273.15:F2} K");
        }
    }
}
