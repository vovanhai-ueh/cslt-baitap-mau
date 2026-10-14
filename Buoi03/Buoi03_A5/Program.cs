/*
 * Bài    : Buoi03_A5 – Tham số out: tách chữ số
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi03_A5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            TachChuSo(482, out int tram, out int chuc, out int donVi);
            Console.WriteLine($"{tram} {chuc} {donVi}");
        }

        static void TachChuSo(int n, out int tram, out int chuc, out int donVi)
        {
            tram = n / 100;
            chuc = n / 10 % 10;
            donVi = n % 10;
        }
    }
}
