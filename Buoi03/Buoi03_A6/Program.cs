/*
 * Bài    : Buoi03_A6 – Nạp chồng và tham số mặc định
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi03_A6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine(DienTich(3, 4, 5));
        }

        static double DienTich(double canh)
        {
            return canh * canh;
        }

        static double DienTich(double dai, double rong)
        {
            return dai * rong;
        }

        static double DienTich(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        static double TinhTienLai(double tienGui, double laiSuat = 0.06, int soNam = 1)
        {
            return tienGui * Math.Pow(1 + laiSuat, soNam) - tienGui;
        }
    }
}
