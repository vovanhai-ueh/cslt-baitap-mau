/*
 * Bài    : Buoi06_B2 – Phần tử lớn thứ hai
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi06_B2
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

        static bool TimLonThuHai(int[] a, out int ketQua)
        {
            int max1 = int.MinValue, max2 = int.MinValue;
            bool co = false;
            foreach (int x in a)
            {
                if (x > max1) { if (max1 != int.MinValue) { max2 = max1; co = true; } max1 = x; }
                else if (x < max1 && (!co || x > max2)) { max2 = x; co = true; }
            }
            ketQua = co ? max2 : 0;
            return co;
        }
    }
}
