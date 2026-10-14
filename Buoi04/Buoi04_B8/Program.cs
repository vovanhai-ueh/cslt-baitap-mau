/*
 * Bài    : Buoi04_B8 – Đọc số có 3 chữ số thành chữ
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi04_B8
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

        static string ChuSo(int d)
        {
            switch (d)
            {
                case 0: return "không"; case 1: return "một"; case 2: return "hai"; case 3: return "ba";
                case 4: return "bốn"; case 5: return "năm"; case 6: return "sáu"; case 7: return "bảy";
                case 8: return "tám"; default: return "chín";
            }
        }

        static string DocSo3ChuSo(int n)
        {
            int tram = n / 100, chuc = n / 10 % 10, dv = n % 10;
            string s = ChuSo(tram) + " trăm";
            if (chuc == 0 && dv == 0) return s;
            if (chuc == 0) s += " linh";
            else if (chuc == 1) s += " mười";
            else s += " " + ChuSo(chuc) + " mươi";
            if (dv == 0) return s;
            if (dv == 1 && chuc >= 2) return s + " mốt";
            if (dv == 5 && chuc >= 1) return s + " lăm";
            if (dv == 4 && chuc >= 2) return s + " tư";
            return s + " " + ChuSo(dv);
        }
    }
}
