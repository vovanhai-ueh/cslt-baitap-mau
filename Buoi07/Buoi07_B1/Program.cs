/*
 * Bài    : Buoi07_B1 – Số âm, số dương từng dòng
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi07_B1
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

        static void DemAmDuongDong(int[,] a, int i, out int soAm, out int soDuong)
        {
            soAm = 0; soDuong = 0;
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[i, j] < 0) soAm++;
                else if (a[i, j] > 0) soDuong++;
            }
        }
    }
}
