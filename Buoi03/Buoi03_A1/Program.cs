/*
 * Bài    : Buoi03_A1 – Hàm đầu tiên
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi03_A1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            InTieuDe("TÍNH DIỆN TÍCH");
            Console.WriteLine($"r = 5: {TinhDienTichHinhTron(5):F2}");
        }

        static void InTieuDe(string tieuDe)
        {
            Console.WriteLine(new string('=', 30));
            Console.WriteLine(tieuDe);
            Console.WriteLine(new string('=', 30));
        }

        static double TinhDienTichHinhTron(double banKinh)
        {
            return Math.PI * banKinh * banKinh;
        }
    }
}
