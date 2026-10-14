/*
 * Bài    : Buoi04_A1 – Phân loại số
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi04_A1
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

        static string PhanLoaiSo(int n)
        {
            string dau;
            if (n > 0)
                dau = "dương";
            else if (n < 0)
                dau = "âm";
            else
                dau = "bằng 0";
            string chanLe = n % 2 == 0 ? "chẵn" : "lẻ";
            return $"{n} là số {dau}, {chanLe}";
        }
    }
}
