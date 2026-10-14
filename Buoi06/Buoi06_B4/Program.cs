/*
 * Bài    : Buoi06_B4 – Xóa mọi phần tử bằng x
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi06_B4
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

        static void XoaMoiX(int[] a, ref int n, int x)
        {
            int k = 0;
            for (int i = 0; i < n; i++) if (a[i] != x) a[k++] = a[i];
            n = k;
        }
    }
}
