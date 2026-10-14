/*
 * Bài    : Buoi04_A3 – Phương trình bậc nhất và bậc hai đầy đủ
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi04_A3
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

        static string GiaiPTBac1(double a, double b)
        {
            if (a != 0)
                return $"x = {-b / a}";
            if (b == 0)
                return "Vô số nghiệm";
            return "Vô nghiệm";
        }

        static string GiaiPTBac2(double a, double b, double c)
        {
            if (a == 0)
                return GiaiPTBac1(b, c);
            double delta = b * b - 4 * a * c;
            if (delta < 0)
                return "Vô nghiệm";
            else if (delta == 0)
                return $"Nghiệm kép x = {-b / (2 * a)}";
            double can = Math.Sqrt(delta);
            return $"x1 = {(-b + can) / (2 * a)}, x2 = {(-b - can) / (2 * a)}";
        }
    }
}
