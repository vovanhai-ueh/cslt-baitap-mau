/*
 * Bài    : Buoi06_A2 – Đếm và tìm kiếm có điều kiện
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi06_A2
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

        static int DemSoChan(int[] a)
        {
            int dem = 0;
            foreach (int x in a) if (x % 2 == 0) dem++;
            return dem;
        }

        static int TimViTriCuoi(int[] a, int x)
        {
            for (int i = a.Length - 1; i >= 0; i--) if (a[i] == x) return i;
            return -1;
        }

        static int InMoiViTri(int[] a, int x)
        {
            int dem = 0;
            for (int i = 0; i < a.Length; i++)
                if (a[i] == x) { Console.Write(i + " "); dem++; }
            Console.WriteLine();
            return dem;
        }
    }
}
