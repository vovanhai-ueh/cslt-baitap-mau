/*
 * Bài    : Buoi06_A6 – Thống kê điểm của lớp
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi06_A6
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

        static double TrungBinh(double[] a)
        {
            double t = 0;
            foreach (double x in a) t += x;
            return t / a.Length;
        }

        static double GiaTriLonNhat(double[] a)
        {
            double m = a[0];
            foreach (double x in a) if (x > m) m = x;
            return m;
        }

        static void DemTheoLoai(double[] a, out int gioi, out int kha, out int tb, out int yeu)
        {
            gioi = kha = tb = yeu = 0;
            foreach (double d in a)
            {
                if (d >= 8) gioi++;
                else if (d >= 6.5) kha++;
                else if (d >= 5) tb++;
                else yeu++;
            }
        }
    }
}
