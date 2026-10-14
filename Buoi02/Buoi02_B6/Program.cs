/*
 * Bài    : Buoi02_B6 – Tiền gửi tiết kiệm lãi kép
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi02_B6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Số tiền gửi P: "); double p = double.Parse(Console.ReadLine());
            Console.Write("Lãi suất r (%/năm): "); double r = double.Parse(Console.ReadLine());
            Console.Write("Số năm n: "); int n = int.Parse(Console.ReadLine());
            double nhan = p * Math.Pow(1 + r / 100, n);
            Console.WriteLine($"Số tiền nhận được: {nhan:N2}");
            Console.WriteLine($"Tiền lãi: {nhan - p:N2}");
        }
    }
}
