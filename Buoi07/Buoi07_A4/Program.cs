/*
 * Bài    : Buoi07_A4 – Chuyển vị, cộng và nhân ma trận
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi07_A4
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

        static int[,] ChuyenVi(int[,] a)
        {
            int m = a.GetLength(0), n = a.GetLength(1);
            int[,] b = new int[n, m];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++) b[j, i] = a[i, j];
            return b;
        }

        static int[,] CongMaTran(int[,] a, int[,] b)
        {
            int m = a.GetLength(0), n = a.GetLength(1);
            if (b.GetLength(0) != m || b.GetLength(1) != n) return null;
            int[,] c = new int[m, n];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++) c[i, j] = a[i, j] + b[i, j];
            return c;
        }

        static int[,] NhanMaTran(int[,] a, int[,] b)
        {
            int m = a.GetLength(0), n = a.GetLength(1), p = b.GetLength(1);
            if (b.GetLength(0) != n) return null;
            int[,] c = new int[m, p];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < p; j++)
                    for (int k = 0; k < n; k++) c[i, j] += a[i, k] * b[k, j];
            return c;
        }
    }
}
