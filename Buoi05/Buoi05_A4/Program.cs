/*
 * Bài    : Buoi05_A4 – Bảng cửu chương và in hình
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi05_A4
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

        static void InBangCuuChuong()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int bang = 2; bang <= 5; bang++)
                    Console.Write($"{bang} x {i,2} = {bang * i,2}    ");
                Console.WriteLine();
            }
        }

        static void InTamGiacVuong(int n)
        {
            for (int dong = 1; dong <= n; dong++)
            {
                for (int k = 1; k <= dong; k++) Console.Write('*');
                Console.WriteLine();
            }
        }

        static void InHinhChuNhatRong(int rong, int cao)
        {
            for (int dong = 1; dong <= cao; dong++)
            {
                for (int cot = 1; cot <= rong; cot++)
                {
                    bool laVien = dong == 1 || dong == cao || cot == 1 || cot == rong;
                    Console.Write(laVien ? '*' : ' ');
                }
                Console.WriteLine();
            }
        }
    }
}
