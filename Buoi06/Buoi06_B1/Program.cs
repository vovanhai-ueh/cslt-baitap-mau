/*
 * Bài    : Buoi06_B1 – Các số nguyên tố trong mảng
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi06_B1
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

        static bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;
            return true;
        }

        static int InSoNguyenTo(int[] a)
        {
            int dem = 0;
            foreach (int x in a) if (LaSoNguyenTo(x)) { Console.Write(x + " "); dem++; }
            Console.WriteLine();
            return dem;
        }
    }
}
