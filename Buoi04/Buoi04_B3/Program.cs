/*
 * Bài    : Buoi04_B3 – Tiền điện bậc thang
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi04_B3
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

        static long TinhTienDien(int kwh)
        {
            if (kwh > 400) return 995000 + (kwh - 400) * 3200L;
            if (kwh > 300) return 685000 + (kwh - 300) * 3100L;
            if (kwh > 200) return 405000 + (kwh - 200) * 2800L;
            if (kwh > 100) return 185000 + (kwh - 100) * 2200L;
            if (kwh > 50) return 90000 + (kwh - 50) * 1900L;
            return kwh * 1800L;
        }
    }
}
