/*
 * Bài    : Buoi04_B4 – Phân loại tam giác
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi04_B4
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

        static string PhanLoaiTamGiac(double a, double b, double c)
        {
            if (!(a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a)) return "Không phải tam giác";
            if (a == b && b == c) return "Đều";
            bool vuong = Math.Abs(a * a + b * b - c * c) < 1e-9 || Math.Abs(a * a + c * c - b * b) < 1e-9 || Math.Abs(b * b + c * c - a * a) < 1e-9;
            bool can = a == b || b == c || a == c;
            if (vuong && can) return "Vuông cân";
            if (vuong) return "Vuông";
            if (can) return "Cân";
            return "Thường";
        }
    }
}
