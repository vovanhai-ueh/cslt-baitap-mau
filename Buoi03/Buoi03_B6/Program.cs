/*
 * Bài    : Buoi03_B6 – Phương trình bậc hai với out
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi03_B6
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

        static void GiaiPTBac2(double a, double b, double c, out double x1, out double x2)
        {
            double canDelta = Math.Sqrt(b * b - 4 * a * c);
            x1 = (-b + canDelta) / (2 * a);
            x2 = (-b - canDelta) / (2 * a);
        }
    }
}
