/*
 * Bài    : Buoi02_B4 – Tách các chữ số của số có 3 chữ số
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi02_B4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Nhập số có 3 chữ số: ");
            int n = int.Parse(Console.ReadLine());
            int tram = n / 100, chuc = n / 10 % 10, dv = n % 10;
            Console.WriteLine($"Trăm: {tram}, chục: {chuc}, đơn vị: {dv}");
            Console.WriteLine($"Tổng các chữ số: {tram + chuc + dv}");
            Console.WriteLine($"Số đảo ngược: {dv * 100 + chuc * 10 + tram}");
        }
    }
}
