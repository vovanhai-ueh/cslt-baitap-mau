/*
 * Bài    : Buoi09_B3 – Xem từng byte của số nguyên (union)
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;
using System.Runtime.InteropServices;

namespace Buoi09_B3
{
    [StructLayout(LayoutKind.Explicit)]
    struct BonByte
    {
        [FieldOffset(0)] public int GiaTri;
        [FieldOffset(0)] public byte B0;
        [FieldOffset(1)] public byte B1;
        [FieldOffset(2)] public byte B2;
        [FieldOffset(3)] public byte B3;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            // Gọi thử các hàm của em ở đây, ví dụ:
            // Console.WriteLine(TenHam(...));
        }
    }
}
