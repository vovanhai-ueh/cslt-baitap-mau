/*
 * Bài    : Buoi02_B2 – Chỉ số BMI
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi02_B2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Cân nặng (kg): ");
            double kg = double.Parse(Console.ReadLine());
            Console.Write("Chiều cao (m): ");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine($"BMI = {kg / (m * m):F2}");
        }
    }
}
