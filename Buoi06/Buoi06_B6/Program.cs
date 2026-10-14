/*
 * Bài    : Buoi06_B6 – Sắp xếp nổi bọt
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi06_B6
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

        static int SapXepNoiBot(int[] a)
        {
            int soDoi = 0, luot = 0;
            bool coDoi;
            do
            {
                coDoi = false;
                luot++;
                for (int i = 0; i < a.Length - 1; i++)
                    if (a[i] > a[i + 1]) { int t = a[i]; a[i] = a[i + 1]; a[i + 1] = t; soDoi++; coDoi = true; }
                Console.WriteLine($"Lượt {luot}: {string.Join(" ", a)}");
            } while (coDoi);
            return soDoi;
        }
    }
}
