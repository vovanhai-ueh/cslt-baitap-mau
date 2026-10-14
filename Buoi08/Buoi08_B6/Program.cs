/*
 * Bài    : Buoi08_B6 – Danh bạ điện thoại
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi08_B6
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

        static bool LaSoDienThoaiHopLe(string sdt)
        {
            if (sdt == null || sdt.Length != 10) return false;
            foreach (char c in sdt) if (c < '0' || c > '9') return false;
            return true;
        }

        static int DocDanhBa(string duongDan, string[] ten, string[] sdt)
        {
            if (!File.Exists(duongDan)) return 0;
            int n = 0;
            foreach (string dong in File.ReadAllLines(duongDan))
            {
                string[] t = dong.Split(',');
                if (t.Length == 2 && n < ten.Length) { ten[n] = t[0]; sdt[n] = t[1]; n++; }
            }
            return n;
        }

        static void GhiDanhBa(string duongDan, string[] ten, string[] sdt, int n)
        {
            using (StreamWriter sw = new StreamWriter(duongDan))
                for (int i = 0; i < n; i++) sw.WriteLine($"{ten[i]},{sdt[i]}");
        }
    }
}
