/*
 * Bài    : Buoi06_B7 – Đoạn con tăng dài nhất
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi06_B7
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

        static void TimDoanTangDaiNhat(int[] a, out int batDau, out int doDai)
        {
            int bd = 0, dai = 1;
            batDau = 0; doDai = 1;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > a[i - 1]) dai++; else { bd = i; dai = 1; }
                if (dai > doDai) { doDai = dai; batDau = bd; }
            }
        }
    }
}
