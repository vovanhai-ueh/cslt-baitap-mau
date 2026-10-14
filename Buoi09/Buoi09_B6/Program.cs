/*
 * Bài    : Buoi09_B6 – Lọc và đếm bằng lambda
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi09_B6
{
    struct SinhVien
    {
        public string MSSV;
        public string HoTen;
        public double DiemTB;
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

        static SinhVien[] LocGioi(SinhVien[] ds)
        {
            return Array.FindAll(ds, sv => sv.DiemTB >= 8);
        }

        static SinhVien TimDauTienDuoi5(SinhVien[] ds)
        {
            return Array.Find(ds, sv => sv.DiemTB < 5);
        }

        static bool CoAiDat10(SinhVien[] ds)
        {
            return Array.Exists(ds, sv => sv.DiemTB == 10);
        }

        static void SapXepTheoTen(SinhVien[] ds)
        {
            Array.Sort(ds, (p, q) => string.Compare(p.HoTen, q.HoTen, StringComparison.Ordinal));
        }
    }
}
