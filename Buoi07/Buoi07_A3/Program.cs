/*
 * Bài    : Buoi07_A3 – Đường chéo và tam giác
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi07_A3
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

        static int TongCheoChinh(int[,] a)
        {
            int tong = 0;
            for (int i = 0; i < a.GetLength(0); i++) tong += a[i, i];
            return tong;
        }

        static int TongCheoPhu(int[,] a)
        {
            int n = a.GetLength(0), tong = 0;
            for (int i = 0; i < n; i++) tong += a[i, n - 1 - i];
            return tong;
        }

        static int TongTamGiacTren(int[,] a)
        {
            int tong = 0;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = i + 1; j < a.GetLength(1); j++) tong += a[i, j];
            return tong;
        }

        static int TongTamGiacDuoi(int[,] a)
        {
            int tong = 0;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < i; j++) tong += a[i, j];
            return tong;
        }

        static bool LaTamGiacTren(int[,] a)
        {
            for (int i = 1; i < a.GetLength(0); i++)
                for (int j = 0; j < i; j++) if (a[i, j] != 0) return false;
            return true;
        }
    }
}
