/*
 * Bài    : Buoi02_A4 – Hóa đơn thẳng cột
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi02_A4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            const decimal ThueVAT = 0.08m;
            string ten1 = "Vở 200 trang"; int sl1 = 5;  decimal gia1 = 15000m;
            string ten2 = "Bút bi";       int sl2 = 10; decimal gia2 = 4500m;
            string ten3 = "Thước kẻ";     int sl3 = 2;  decimal gia3 = 8000m;
            decimal tt1 = sl1 * gia1, tt2 = sl2 * gia2, tt3 = sl3 * gia3;
            decimal tong = tt1 + tt2 + tt3;
            decimal thue = tong * ThueVAT;
            decimal thanhToan = tong + thue;
            Console.WriteLine($"{"Mặt hàng",-16}{"SL",4}{"Đơn giá",12}{"Thành tiền",14}");
            Console.WriteLine(new string('-', 46));
            Console.WriteLine($"{ten1,-16}{sl1,4}{gia1,12:N0}{tt1,14:N0}");
            Console.WriteLine($"{ten2,-16}{sl2,4}{gia2,12:N0}{tt2,14:N0}");
            Console.WriteLine($"{ten3,-16}{sl3,4}{gia3,12:N0}{tt3,14:N0}");
            Console.WriteLine(new string('-', 46));
            Console.WriteLine($"{"Cộng",-32}{tong,14:N0}");
            Console.WriteLine($"{"Thuế VAT 8%",-32}{thue,14:N0}");
            Console.WriteLine($"{"THANH TOÁN",-32}{thanhToan,14:N0}");
        }
    }
}
