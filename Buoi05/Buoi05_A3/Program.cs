/*
 * Bài    : Buoi05_A3 – Xử lý chữ số
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi05_A3
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

        static int DemChuSo(int n)
        {
            int dem = 0;
            do { dem++; n /= 10; } while (n != 0);
            return dem;
        }

        static int TongChuSo(int n)
        {
            int tong = 0;
            while (n > 0) { tong += n % 10; n /= 10; }
            return tong;
        }

        static int DaoSo(int n)
        {
            int dao = 0;
            while (n > 0) { dao = dao * 10 + n % 10; n /= 10; }
            return dao;
        }

        static bool LaSoDoiXung(int n)
        {
            return DaoSo(n) == n;
        }
    }
}
