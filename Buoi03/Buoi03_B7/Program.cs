/*
 * Bài    : Buoi03_B7 – Số ngày giữa hai ngày
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi03_B7
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

        static int SoNgayJulian(int ngay, int thang, int nam)
        {
            int a = (14 - thang) / 12;
            int y = nam + 4800 - a;
            int m = thang + 12 * a - 3;
            return ngay + (153 * m + 2) / 5 + 365 * y + y / 4 - y / 100 + y / 400 - 32045;
        }

        static int SoNgayGiua(int ngay1, int thang1, int nam1, int ngay2, int thang2, int nam2)
        {
            return SoNgayJulian(ngay2, thang2, nam2) - SoNgayJulian(ngay1, thang1, nam1);
        }
    }
}
