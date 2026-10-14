/*
 * Bài    : Buoi03_A4 – Thí nghiệm tham trị và ref
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi03_A4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            int x = 3, y = 8;
            HoanDoi(ref x, ref y);
            Console.WriteLine($"x = {x}, y = {y}");
        }

        static void Tang(int x)
        {
            x = x + 1;
        }

        static void TangRef(ref int x)
        {
            x = x + 1;
        }

        static void HoanDoi(ref int a, ref int b)
        {
            int tam = a;
            a = b;
            b = tam;
        }
    }
}
