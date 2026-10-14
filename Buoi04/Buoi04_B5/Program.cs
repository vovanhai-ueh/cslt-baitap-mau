/*
 * Bài    : Buoi04_B5 – Cước taxi
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi04_B5
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

        static long TinhCuocTaxi(int km)
        {
            if (km <= 1) return 12000;
            if (km <= 30) return 12000 + (km - 1) * 10000L;
            return 12000 + 29 * 10000L + (km - 30) * 8000L;
        }
    }
}
