/*
 * Bài    : Buoi07_B7 – Ma trận xoắn ốc
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi07_B7
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

        static int[,] TaoXoanOc(int n)
        {
            int[,] a = new int[n, n];
            int tren = 0, duoi = n - 1, trai = 0, phai = n - 1, k = 1;
            while (tren <= duoi && trai <= phai)
            {
                for (int j = trai; j <= phai; j++) a[tren, j] = k++;
                tren++;
                for (int i = tren; i <= duoi; i++) a[i, phai] = k++;
                phai--;
                if (tren <= duoi) { for (int j = phai; j >= trai; j--) a[duoi, j] = k++; duoi--; }
                if (trai <= phai) { for (int i = duoi; i >= tren; i--) a[i, trai] = k++; trai++; }
            }
            return a;
        }
    }
}
