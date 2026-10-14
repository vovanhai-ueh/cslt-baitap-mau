/*
 * Bài    : Buoi05_B8 – Số Armstrong 3 chữ số
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi05_B8
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

        static bool LaSoArmstrong(int n)
        {
            int a = n / 100, b = n / 10 % 10, c = n % 10;
            return a * a * a + b * b * b + c * c * c == n;
        }
    }
}
