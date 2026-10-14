/*
 * Bài    : Buoi04_A4 – Tên thứ và số ngày trong tháng (switch)
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi04_A4
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

        static string TenThu(int thu)
        {
            switch (thu)
            {
                case 0: return "Chủ nhật";
                case 1: return "Thứ Hai";
                case 2: return "Thứ Ba";
                case 3: return "Thứ Tư";
                case 4: return "Thứ Năm";
                case 5: return "Thứ Sáu";
                case 6: return "Thứ Bảy";
                default: return "Không hợp lệ";
            }
        }

        static bool LaNgayHopLe(int ngay, int thang, int nam)
        {
            return nam >= 1 && thang >= 1 && thang <= 12
                && ngay >= 1 && ngay <= SoNgayTrongThang(thang, nam);
        }

        static int ThuTrongTuan(int ngay, int thang, int nam)
        {
            int a = (14 - thang) / 12;
            int y = nam - a;
            int m = thang + 12 * a - 2;
            return (ngay + y + y / 4 - y / 100 + y / 400 + 31 * m / 12) % 7;
        }
    }
}
