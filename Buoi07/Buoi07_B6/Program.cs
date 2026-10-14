/*
 * Bài    : Buoi07_B6 – Sắp xếp từng dòng của mảng răng cưa
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi07_B6
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

        static void SapXepTungDong(int[][] a)
        {
            foreach (int[] dong in a)
                for (int i = 0; i < dong.Length - 1; i++)
                {
                    int vt = i;
                    for (int j = i + 1; j < dong.Length; j++) if (dong[j] < dong[vt]) vt = j;
                    int t = dong[i]; dong[i] = dong[vt]; dong[vt] = t;
                }
        }

        static void SapXepTheoDoDai(int[][] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
                for (int j = i + 1; j < a.Length; j++)
                    if (a[j].Length < a[i].Length) { int[] t = a[i]; a[i] = a[j]; a[j] = t; }
        }
    }
}
