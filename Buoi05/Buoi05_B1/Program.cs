/*
 * Bài    : Buoi05_B1 – Tổng nghịch đảo
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi05_B1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            // Gọi thử các hàm của em ở đây, ví dụ:
            // Console.WriteLine(TenHam(...));
        }

        static double TongNghichDao(int n)
        {
            double s = 0;
            for (int i = 1; i <= n; i++) s += 1.0 / i;
            return s;
        }
    }
}
