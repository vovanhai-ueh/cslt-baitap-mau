/*
 * Bài    : Buoi07_B5 – Điểm yên ngựa
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi07_B5
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

        static bool LaNhoNhatDong(int[,] a, int i, int j)
        {
            for (int k = 0; k < a.GetLength(1); k++) if (a[i, k] < a[i, j]) return false;
            return true;
        }

        static bool LaLonNhatCot(int[,] a, int i, int j)
        {
            for (int k = 0; k < a.GetLength(0); k++) if (a[k, j] > a[i, j]) return false;
            return true;
        }

        static int InDiemYenNgua(int[,] a)
        {
            int dem = 0;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    if (LaNhoNhatDong(a, i, j) && LaLonNhatCot(a, i, j))
                    {
                        Console.WriteLine($"{a[i, j]} tại ({i}, {j})");
                        dem++;
                    }
            if (dem == 0) Console.WriteLine("Không có");
            return dem;
        }
    }
}
