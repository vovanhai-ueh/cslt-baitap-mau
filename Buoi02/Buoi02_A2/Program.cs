/*
 * Bài    : Buoi02_A2 – Hình chữ nhật nhập từ bàn phím
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi02_A2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Nhập chiều dài: ");
            double dai = double.Parse(Console.ReadLine());
            Console.Write("Nhập chiều rộng: ");
            double rong = double.Parse(Console.ReadLine());
            double chuVi = 2 * (dai + rong);
            double dienTich = dai * rong;
            double duongCheo = Math.Sqrt(dai * dai + rong * rong);
            Console.WriteLine($"Chu vi     : {chuVi:F2}");
            Console.WriteLine($"Diện tích  : {dienTich:F2}");
            Console.WriteLine($"Đường chéo : {duongCheo:F2}");
        }
    }
}
