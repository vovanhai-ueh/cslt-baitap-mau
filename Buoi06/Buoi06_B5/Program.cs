/*
 * Bài    : Buoi06_B5 – Trộn hai mảng đã sắp xếp
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi06_B5
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

        static int[] TronMang(int[] a, int[] b)
        {
            int[] c = new int[a.Length + b.Length];
            int i = 0, j = 0, k = 0;
            while (i < a.Length && j < b.Length) c[k++] = a[i] <= b[j] ? a[i++] : b[j++];
            while (i < a.Length) c[k++] = a[i++];
            while (j < b.Length) c[k++] = b[j++];
            return c;
        }
    }
}
