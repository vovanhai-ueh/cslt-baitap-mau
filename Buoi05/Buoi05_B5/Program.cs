/*
 * Bài    : Buoi05_B5 – Dãy Fibonacci
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi05_B5
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

        static long Fibonacci(int k)
        {
            long a = 1, b = 1;
            for (int i = 3; i <= k; i++) { long c = a + b; a = b; b = c; }
            return b;
        }
    }
}
