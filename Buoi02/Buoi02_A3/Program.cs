/*
 * Bài    : Buoi02_A3 – Đổi số giây ra giờ, phút, giây
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi02_A3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Nhập tổng số giây: ");
            int tongGiay = int.Parse(Console.ReadLine());
            int gio = tongGiay / 3600;
            int phut = tongGiay % 3600 / 60;
            int giay = tongGiay % 60;
            Console.WriteLine($"{tongGiay} giây = {gio} giờ {phut} phút {giay} giây");
            Console.WriteLine($"Dạng đồng hồ: {gio:D2}:{phut:D2}:{giay:D2}");
        }
    }
}
