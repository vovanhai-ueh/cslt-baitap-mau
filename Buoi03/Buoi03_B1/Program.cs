/*
 * Bài    : Buoi03_B1 – Hàm đổi nhiệt độ hai chiều
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi03_B1
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

        static double DoiCsangF(double c)
        {
            return c * 9 / 5 + 32;
        }

        static double DoiFsangC(double f)
        {
            return (f - 32) * 5 / 9;
        }
    }
}
