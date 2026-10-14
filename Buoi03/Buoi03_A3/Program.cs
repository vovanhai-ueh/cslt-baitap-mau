/*
 * Bài    : Buoi03_A3 – Mô-đun hóa chương trình hóa đơn
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi03_A3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            decimal tong = TinhThanhTien(5, 15000m) + TinhThanhTien(10, 4500m) + TinhThanhTien(2, 8000m);
            Console.WriteLine($"THANH TOÁN {tong + TinhThue(tong):N0}");
        }

        static decimal TinhThanhTien(int soLuong, decimal donGia)
        {
            return soLuong * donGia;
        }

        static decimal TinhThue(decimal tien)
        {
            return tien * 0.08m;
        }
    }
}
