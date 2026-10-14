/*
 * Bài    : Buoi09_A2 – enum và switch
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi09_A2
{
    enum XepLoai { Yeu, TrungBinh, Kha, Gioi }
    enum Thu { ChuNhat, ThuHai, ThuBa, ThuTu, ThuNam, ThuSau, ThuBay }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            // Gọi thử các hàm của em ở đây, ví dụ:
            // Console.WriteLine(TenHam(...));
        }

        static XepLoai PhanLoai(double tb)
        {
            return tb >= 8 ? XepLoai.Gioi : tb >= 6.5 ? XepLoai.Kha : tb >= 5 ? XepLoai.TrungBinh : XepLoai.Yeu;
        }

        static Thu ThuTrongTuan(int ngay, int thang, int nam)
        {
            int a = (14 - thang) / 12, y = nam - a, m = thang + 12 * a - 2;
            return (Thu)((ngay + y + y / 4 - y / 100 + y / 400 + 31 * m / 12) % 7);
        }

        static string TenTiengViet(Thu t)
        {
            switch (t)
            {
                case Thu.ChuNhat: return "Chủ nhật";
                case Thu.ThuHai: return "Thứ Hai";
                case Thu.ThuBa: return "Thứ Ba";
                case Thu.ThuTu: return "Thứ Tư";
                case Thu.ThuNam: return "Thứ Năm";
                case Thu.ThuSau: return "Thứ Sáu";
                default: return "Thứ Bảy";
            }
        }
    }
}
