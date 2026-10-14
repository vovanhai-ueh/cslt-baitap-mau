/*
 * Bài    : Buoi02_B8 – Thứ trong tuần của một ngày
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi02_B8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Ngày: "); int ngay = int.Parse(Console.ReadLine());
            Console.Write("Tháng: "); int thang = int.Parse(Console.ReadLine());
            Console.Write("Năm: "); int nam = int.Parse(Console.ReadLine());
            int a = (14 - thang) / 12;
            int y = nam - a;
            int m = thang + 12 * a - 2;
            int thu = (ngay + y + y / 4 - y / 100 + y / 400 + 31 * m / 12) % 7;
            Console.WriteLine($"Thứ (0 = Chủ nhật): {thu}");
        }
    }
}
