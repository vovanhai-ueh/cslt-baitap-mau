/*
 * Bài    : Buoi09_A3 – class PhanSo có đóng gói
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi09_A3
{
    class PhanSo
    {
        private int tu, mau;

        public PhanSo(int tu, int mau)
        {
            if (mau == 0) throw new ArgumentException("Mẫu số phải khác 0");
            if (mau < 0) { tu = -tu; mau = -mau; }
            int u = UCLN(Math.Abs(tu), mau);
            this.tu = tu / u;
            this.mau = mau / u;
        }

        private static int UCLN(int a, int b)
        {
            while (b != 0) { int r = a % b; a = b; b = r; }
            return a == 0 ? 1 : a;
        }

        public PhanSo Cong(PhanSo p) => new PhanSo(tu * p.mau + p.tu * mau, mau * p.mau);
        public PhanSo Nhan(PhanSo p) => new PhanSo(tu * p.tu, mau * p.mau);
        public double GiaTri => (double)tu / mau;
        public override string ToString() => mau == 1 ? $"{tu}" : $"{tu}/{mau}";
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
