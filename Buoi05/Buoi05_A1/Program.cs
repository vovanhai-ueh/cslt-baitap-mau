/*
 * Bài    : Buoi05_A1 – Tổng, đếm và chạy tay vòng lặp
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi05_A1
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

        static int TongDen(int n)
        {
            int tong = 0;
            for (int i = 1; i <= n; i++) tong += i;
            return tong;
        }

        static int DemSoChan(int a, int b)
        {
            int dem = 0;
            for (int i = a; i <= b; i++)
                if (i % 2 == 0) dem++;
            return dem;
        }
    }
}
