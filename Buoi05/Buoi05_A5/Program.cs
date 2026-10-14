/*
 * Bài    : Buoi05_A5 – UCLN, BCNN và số nguyên tố
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi05_A5
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

        static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0) { int r = a % b; a = b; b = r; }
            return a;
        }

        static int BCNN(int a, int b)
        {
            return a / UCLN(a, b) * b;
        }

        static bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;
            return true;
        }

        static int LietKeNguyenTo(int a, int b)
        {
            int dem = 0;
            for (int n = a; n <= b; n++)
                if (LaSoNguyenTo(n)) { Console.Write(n + " "); dem++; }
            Console.WriteLine();
            return dem;
        }
    }
}
