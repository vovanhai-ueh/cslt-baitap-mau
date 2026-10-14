/*
 * Bài    : Buoi06_A4 – Chèn, xóa phần tử
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi06_A4
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

        static bool ChenPhanTu(int[] a, ref int n, int viTri, int x)
        {
            if (n >= a.Length || viTri < 0 || viTri > n) return false;
            for (int i = n; i > viTri; i--) a[i] = a[i - 1];
            a[viTri] = x;
            n++;
            return true;
        }

        static bool XoaPhanTu(int[] a, ref int n, int viTri)
        {
            if (viTri < 0 || viTri >= n) return false;
            for (int i = viTri; i < n - 1; i++) a[i] = a[i + 1];
            n--;
            return true;
        }

        static void InMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++) Console.Write(a[i] + " ");
            Console.WriteLine();
        }
    }
}
