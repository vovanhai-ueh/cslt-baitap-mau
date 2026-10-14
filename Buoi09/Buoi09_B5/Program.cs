/*
 * Bài    : Buoi09_B5 – Lớp generic Cap<T1, T2>
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi09_B5
{
    class Cap<T1, T2>
    {
        public T1 Dau { get; }
        public T2 Sau { get; }

        public Cap(T1 dau, T2 sau) { Dau = dau; Sau = sau; }

        public Cap<T2, T1> Dao() => new Cap<T2, T1>(Sau, Dau);
        public override string ToString() => $"({Dau}, {Sau})";
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

        static Cap<int, int> TimMinMax(int[] a)
        {
            int min = a[0], max = a[0];
            foreach (int x in a) { if (x < min) min = x; if (x > max) max = x; }
            return new Cap<int, int>(min, max);
        }
    }
}
