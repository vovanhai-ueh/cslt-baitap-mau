/*
 * Bài    : Buoi03_A2 – Hàm nhập liệu dùng lại được
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi03_A2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            double dai = NhapSoThuc("Nhập chiều dài: ");
            double rong = NhapSoThuc("Nhập chiều rộng: ");
            Console.WriteLine($"Chu vi: {TinhChuVi(dai, rong):F2}");
        }

        static double NhapSoThuc(string loiNhac)
        {
            Console.Write(loiNhac);
            return double.Parse(Console.ReadLine());
        }

        static int NhapSoNguyen(string loiNhac)
        {
            Console.Write(loiNhac);
            return int.Parse(Console.ReadLine());
        }

        static double TinhChuVi(double dai, double rong)
        {
            return 2 * (dai + rong);
        }

        static double TinhDienTich(double dai, double rong)
        {
            return dai * rong;
        }

        static double TinhDuongCheo(double dai, double rong)
        {
            return Math.Sqrt(dai * dai + rong * rong);
        }
    }
}
