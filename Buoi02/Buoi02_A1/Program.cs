/*
 * Bài    : Buoi02_A1 – Khảo sát giới hạn các kiểu số
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi02_A1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine($"byte   : {byte.MinValue} .. {byte.MaxValue} ({sizeof(byte)} byte)");
            Console.WriteLine($"short  : {short.MinValue} .. {short.MaxValue} ({sizeof(short)} byte)");
            Console.WriteLine($"int    : {int.MinValue} .. {int.MaxValue} ({sizeof(int)} byte)");
            Console.WriteLine($"long   : {long.MinValue} .. {long.MaxValue} ({sizeof(long)} byte)");
            Console.WriteLine($"double : {double.MinValue} .. {double.MaxValue} ({sizeof(double)} byte)");
            Console.WriteLine($"decimal: {decimal.MinValue} .. {decimal.MaxValue} ({sizeof(decimal)} byte)");
            int m = int.MaxValue;
            m = m + 1;
            Console.WriteLine($"int.MaxValue + 1 = {m}");
            long danSo = 8_100_000_000;
            Console.WriteLine($"Dân số thế giới (long): {danSo:N0}");
        }
    }
}
