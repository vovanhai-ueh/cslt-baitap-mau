/*
 * Bài    : Buoi02_B7 – Làm tròn đến hàng nghìn
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi02_B7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Nhập số tiền: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Làm tròn: {(n + 500) / 1000 * 1000}");
        }
    }
}
