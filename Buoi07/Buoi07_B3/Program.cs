/*
 * Bài    : Buoi07_B3 – Dòng, cột có tổng lớn nhất
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi07_B3
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

        static int TongDong(int[,] a, int i)
        {
            int tong = 0;
            for (int j = 0; j < a.GetLength(1); j++) tong += a[i, j];
            return tong;
        }

        static int TongCot(int[,] a, int j)
        {
            int tong = 0;
            for (int i = 0; i < a.GetLength(0); i++) tong += a[i, j];
            return tong;
        }

        static int DongTongLonNhat(int[,] a)
        {
            int vt = 0;
            for (int i = 1; i < a.GetLength(0); i++) if (TongDong(a, i) > TongDong(a, vt)) vt = i;
            return vt;
        }

        static int CotTongLonNhat(int[,] a)
        {
            int vt = 0;
            for (int j = 1; j < a.GetLength(1); j++) if (TongCot(a, j) > TongCot(a, vt)) vt = j;
            return vt;
        }
    }
}
