/*
 * Bài    : Buoi03_B8 – Thiết kế chương trình tính lương
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi03_B8
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

        static double TinhLuongThang(double luongCoBan, double heSo, int ngayCong)
        {
            return luongCoBan * heSo * ngayCong / 26;
        }

        static double TinhBaoHiem(double luongThang)
        {
            return luongThang * 0.105;
        }

        static double TinhThucLinh(double luongThang)
        {
            return luongThang - TinhBaoHiem(luongThang);
        }
    }
}
