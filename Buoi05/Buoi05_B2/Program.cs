/*
 * Bài    : Buoi05_B2 – Đếm và tính tổng các ước
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi05_B2
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

        static int DemUoc(int n)
        {
            int dem = 0;
            for (int i = 1; i <= n; i++) if (n % i == 0) dem++;
            return dem;
        }

        static int TongUoc(int n)
        {
            int tong = 0;
            for (int i = 1; i <= n; i++) if (n % i == 0) tong += i;
            return tong;
        }
    }
}
