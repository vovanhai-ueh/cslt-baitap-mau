/*
 * Bài    : Buoi07_A2 – Lớn nhất, nhỏ nhất và vị trí
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi07_A2
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

        static void TimLonNhat(int[,] a, out int dong, out int cot)
        {
            dong = 0; cot = 0;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    if (a[i, j] > a[dong, cot]) { dong = i; cot = j; }
        }

        static void TimNhoNhat(int[,] a, out int dong, out int cot)
        {
            dong = 0; cot = 0;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    if (a[i, j] < a[dong, cot]) { dong = i; cot = j; }
        }

        static int DemGiaTri(int[,] a, int x)
        {
            int dem = 0;
            foreach (int v in a) if (v == x) dem++;
            return dem;
        }
    }
}
