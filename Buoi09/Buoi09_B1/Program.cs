/*
 * Bài    : Buoi09_B1 – struct Diem2D và khoảng cách
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi09_B1
{
    struct Diem2D
    {
        public double X;
        public double Y;

        public Diem2D(double x, double y) { X = x; Y = y; }

        public double KhoangCach(Diem2D d) => Math.Sqrt((X - d.X) * (X - d.X) + (Y - d.Y) * (Y - d.Y));
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

        static double ChuViDaGiac(Diem2D[] ds)
        {
            double cv = 0;
            for (int i = 0; i < ds.Length; i++) cv += ds[i].KhoangCach(ds[(i + 1) % ds.Length]);
            return cv;
        }
    }
}
