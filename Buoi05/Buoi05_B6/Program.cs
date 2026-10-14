/*
 * Bài    : Buoi05_B6 – Căn bậc hai bằng phương pháp Newton
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi05_B6
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

        static double CanBacHai(double a)
        {
            if (a == 0) return 0;
            double x = a, cu;
            do { cu = x; x = (x + a / x) / 2; } while (Math.Abs(x - cu) > 1e-12);
            return x;
        }
    }
}
