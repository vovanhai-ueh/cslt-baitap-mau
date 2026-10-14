/*
 * Bài    : Buoi04_B6 – Ngày hôm sau
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi04_B6
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

        static bool LaNamNhuan(int nam)
        {
            return (nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0;
        }

        static int SoNgayTrongThang(int thang, int nam)
        {
            switch (thang)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    return 31;
                case 4: case 6: case 9: case 11:
                    return 30;
                case 2:
                    return LaNamNhuan(nam) ? 29 : 28;
                default:
                    return -1;
            }
        }

        static void NgayHomSau(ref int ngay, ref int thang, ref int nam)
        {
            if (ngay < SoNgayTrongThang(thang, nam)) { ngay++; return; }
            ngay = 1;
            if (thang < 12) { thang++; return; }
            thang = 1;
            nam++;
        }
    }
}
