/*
 * Bài    : Buoi07_A5 – Mảng răng cưa: tam giác Pascal
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi07_A5
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

        static int[][] TaoPascal(int soDong)
        {
            int[][] p = new int[soDong][];
            for (int i = 0; i < soDong; i++)
            {
                p[i] = new int[i + 1];
                p[i][0] = p[i][i] = 1;
                for (int j = 1; j < i; j++) p[i][j] = p[i - 1][j - 1] + p[i - 1][j];
            }
            return p;
        }
    }
}
