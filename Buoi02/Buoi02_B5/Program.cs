/*
 * Bài    : Buoi02_B5 – Hoán đổi hai biến
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi02_B5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("a = "); int a = int.Parse(Console.ReadLine());
            Console.Write("b = "); int b = int.Parse(Console.ReadLine());
            int tam = a; a = b; b = tam;
            Console.WriteLine($"Sau hoán đổi: a = {a}, b = {b}");
        }
    }
}
