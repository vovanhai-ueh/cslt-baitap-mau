/*
 * Bài    : Buoi05_A2 – Nhập lại đến khi hợp lệ
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi05_A2
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

        static int NhapSoNguyenTrongKhoang(string loiNhac, int min, int max)
        {
            int x;
            bool hopLe;
            do
            {
                Console.Write(loiNhac);
                hopLe = int.TryParse(Console.ReadLine(), out x) && x >= min && x <= max;
                if (!hopLe)
                    Console.WriteLine($"  Không hợp lệ, hãy nhập số nguyên từ {min} đến {max}.");
            } while (!hopLe);
            return x;
        }

        static double NhapSoThucTrongKhoang(string loiNhac, double min, double max)
        {
            double x;
            bool hopLe;
            do
            {
                Console.Write(loiNhac);
                hopLe = double.TryParse(Console.ReadLine(), out x) && x >= min && x <= max;
                if (!hopLe)
                    Console.WriteLine($"  Không hợp lệ, hãy nhập số từ {min} đến {max}.");
            } while (!hopLe);
            return x;
        }
    }
}
