/*
 * Bài    : Buoi03_B3 – Khoảng cách và chu vi tam giác
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi03_B3
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

        static double KhoangCach(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }

        static double ChuViTamGiac(double xA, double yA, double xB, double yB, double xC, double yC)
        {
            return KhoangCach(xA, yA, xB, yB) + KhoangCach(xB, yB, xC, yC) + KhoangCach(xC, yC, xA, yA);
        }
    }
}
