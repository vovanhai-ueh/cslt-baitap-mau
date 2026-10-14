/*
 * Bài    : Buoi08_B2 – Sao chép tệp có đánh số dòng
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi08_B2
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

        static void SaoChepDanhSo(string nguon, string dich)
        {
            string[] dong = File.ReadAllLines(nguon);
            using (StreamWriter sw = new StreamWriter(dich))
                for (int i = 0; i < dong.Length; i++) sw.WriteLine($"{i + 1,3}: {dong[i]}");
        }
    }
}
