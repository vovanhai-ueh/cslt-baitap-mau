/*
 * Bài    : Buoi07_B2 – Ma trận đơn vị và ma trận đối xứng
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi07_B2
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

        static int[,] TaoMaTranDonVi(int n)
        {
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++) a[i, i] = 1;
            return a;
        }

        static bool LaDoiXung(int[,] a)
        {
            int n = a.GetLength(0);
            if (a.GetLength(1) != n) return false;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < i; j++) if (a[i, j] != a[j, i]) return false;
            return true;
        }
    }
}
