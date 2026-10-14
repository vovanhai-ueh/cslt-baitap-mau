/*
 * Bài    : Buoi06_A1 – Nhập, xuất và thống kê mảng
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi06_A1
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

        static int Tong(int[] a)
        {
            int tong = 0;
            foreach (int x in a) tong += x;
            return tong;
        }

        static int ViTriLonNhat(int[] a)
        {
            int vt = 0;
            for (int i = 1; i < a.Length; i++) if (a[i] > a[vt]) vt = i;
            return vt;
        }

        static int ViTriNhoNhat(int[] a)
        {
            int vt = 0;
            for (int i = 1; i < a.Length; i++) if (a[i] < a[vt]) vt = i;
            return vt;
        }
    }
}
