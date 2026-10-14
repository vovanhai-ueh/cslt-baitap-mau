/*
 * Bài    : Buoi07_B4 – Xoay ma trận 90 độ
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi07_B4
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

        static int[,] XoayPhai90(int[,] a)
        {
            int m = a.GetLength(0), n = a.GetLength(1);
            int[,] b = new int[n, m];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++) b[j, m - 1 - i] = a[i, j];
            return b;
        }
    }
}
