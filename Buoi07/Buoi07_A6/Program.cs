/*
 * Bài    : Buoi07_A6 – Bảng điểm sinh viên × môn học
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi07_A6
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

        static double TrungBinhDong(double[,] d, int i)
        {
            double tong = 0;
            for (int j = 0; j < d.GetLength(1); j++) tong += d[i, j];
            return tong / d.GetLength(1);
        }

        static double TrungBinhCot(double[,] d, int j)
        {
            double tong = 0;
            for (int i = 0; i < d.GetLength(0); i++) tong += d[i, j];
            return tong / d.GetLength(0);
        }
    }
}
