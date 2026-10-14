/*
 * Bài    : Buoi09_B4 – Con trỏ: đảo mảng
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi09_B4
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

        static unsafe void DaoMang(int* p, int n)
        {
            int* dau = p, cuoi = p + n - 1;
            while (dau < cuoi)
            {
                int t = *dau; *dau = *cuoi; *cuoi = t;
                dau++; cuoi--;
            }
        }
    }
}
