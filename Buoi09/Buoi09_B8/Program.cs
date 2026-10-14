/*
 * Bài    : Buoi09_B8 – Hàng đợi vòng generic
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi09_B8
{
    class HangDoiVong<T>
    {
        private T[] a;
        private int dau, soPhanTu;

        public HangDoiVong(int sucChua) { a = new T[sucChua]; }

        public int SoPhanTu => soPhanTu;

        public bool Them(T x)
        {
            if (soPhanTu == a.Length) return false;
            a[(dau + soPhanTu) % a.Length] = x;
            soPhanTu++;
            return true;
        }

        public T Lay()
        {
            if (soPhanTu == 0) throw new InvalidOperationException("Hàng đợi rỗng");
            T x = a[dau];
            dau = (dau + 1) % a.Length;
            soPhanTu--;
            return x;
        }
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
