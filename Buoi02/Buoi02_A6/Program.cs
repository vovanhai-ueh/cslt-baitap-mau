/*
 * Bài    : Buoi02_A6 – Biểu thức logic: năm nhuận và tam giác
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi02_A6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Nhập năm: ");
            int nam = int.Parse(Console.ReadLine());
            bool laNhuan = (nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0;
            Console.WriteLine($"Năm {nam} nhuận? {laNhuan}");
            Console.WriteLine("Nhập 3 cạnh a, b, c (mỗi số một dòng):");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            bool laTamGiac = a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a;
            Console.WriteLine($"Ba cạnh tạo thành tam giác? {laTamGiac}");
        }
    }
}
