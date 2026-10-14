/*
 * Bài    : Buoi04_B7 – Hệ hai phương trình bậc nhất
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi04_B7
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

        static string GiaiHePT(double a1, double b1, double c1, double a2, double b2, double c2)
        {
            double d = a1 * b2 - a2 * b1, dx = c1 * b2 - c2 * b1, dy = a1 * c2 - a2 * c1;
            if (d != 0) return $"x = {dx / d}, y = {dy / d}";
            if (dx == 0 && dy == 0) return "Vô số nghiệm";
            return "Vô nghiệm";
        }
    }
}
