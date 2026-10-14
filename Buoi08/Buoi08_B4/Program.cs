/*
 * Bài    : Buoi08_B4 – Gộp hai tệp số đã sắp xếp
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi08_B4
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

        static void GopTep(string tep1, string tep2, string tepKetQua)
        {
            using (StreamReader r1 = new StreamReader(tep1))
            using (StreamReader r2 = new StreamReader(tep2))
            using (StreamWriter w = new StreamWriter(tepKetQua))
            {
                string s1 = DocSo(r1), s2 = DocSo(r2);
                while (s1 != null && s2 != null)
                {
                    if (int.Parse(s1) <= int.Parse(s2)) { w.WriteLine(s1); s1 = DocSo(r1); }
                    else { w.WriteLine(s2); s2 = DocSo(r2); }
                }
                while (s1 != null) { w.WriteLine(s1); s1 = DocSo(r1); }
                while (s2 != null) { w.WriteLine(s2); s2 = DocSo(r2); }
            }
        }

        static string DocSo(StreamReader r)
        {
            string s;
            while ((s = r.ReadLine()) != null && s.Trim() == "") { }
            return s?.Trim();
        }
    }
}
