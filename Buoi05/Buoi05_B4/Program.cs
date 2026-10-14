/*
 * Bài    : Buoi05_B4 – Tam giác sao rỗng
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi05_B4
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

        static void InKimTuThapRong(int n)
        {
            for (int dong = 1; dong <= n; dong++)
            {
                for (int k = 0; k < n - dong; k++) Console.Write(' ');
                for (int k = 1; k <= 2 * dong - 1; k++)
                    Console.Write(k == 1 || k == 2 * dong - 1 || dong == n ? '*' : ' ');
                Console.WriteLine();
            }
        }
    }
}
