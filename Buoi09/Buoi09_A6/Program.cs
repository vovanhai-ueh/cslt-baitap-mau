/*
 * Bài    : Buoi09_A6 – Quản lý sinh viên tổng hợp
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi09_A6
{
    class SinhVien
    {
        public string MSSV { get; }
        public string HoTen { get; set; }
        public double DiemTB { get; set; }

        public SinhVien(string mssv, string hoTen, double diemTB)
        {
            MSSV = mssv;
            HoTen = hoTen;
            DiemTB = diemTB;
        }

        public XepLoai Loai => DiemTB >= 8 ? XepLoai.Gioi
            : DiemTB >= 6.5 ? XepLoai.Kha
            : DiemTB >= 5 ? XepLoai.TrungBinh : XepLoai.Yeu;

        public string ToCsv() => $"{MSSV},{HoTen},{DiemTB.ToString(CultureInfo.InvariantCulture)}";
        public override string ToString() => $"{MSSV} {HoTen,-14} {DiemTB,5} {Loai}";
    }

    enum XepLoai { Yeu, TrungBinh, Kha, Gioi }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            // Gọi thử các hàm của em ở đây, ví dụ:
            // Console.WriteLine(TenHam(...));
        }

        static List<SinhVien> DocTep(string tep)
        {
            List<SinhVien> ds = new List<SinhVien>();
            if (!File.Exists(tep)) return ds;
            foreach (string dong in File.ReadAllLines(tep))
            {
                string[] t = dong.Split(',');
                if (t.Length == 3 && double.TryParse(t[2], NumberStyles.Float, CultureInfo.InvariantCulture, out double d))
                    ds.Add(new SinhVien(t[0], t[1], d));
            }
            return ds;
        }

        static void GhiTep(string tep, List<SinhVien> ds)
        {
            using (StreamWriter sw = new StreamWriter(tep))
                foreach (SinhVien sv in ds) sw.WriteLine(sv.ToCsv());
        }
    }
}
