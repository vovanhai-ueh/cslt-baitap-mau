/*
 * Bài    : Buoi08_B8 – Báo cáo từ tệp CSV bán hàng
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi08_B8
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

        static void BaoCaoBanHang(string duongDan, out string[] sanPham, out long[] doanhThu)
        {
            string[] dong = File.ReadAllLines(duongDan);
            string[] sp = new string[dong.Length];
            long[] dt = new long[dong.Length];
            int k = 0;
            for (int i = 1; i < dong.Length; i++)
            {
                string[] t = dong[i].Split(',');
                if (t.Length < 4) continue;
                int vt = -1;
                for (int j = 0; j < k; j++) if (sp[j] == t[1]) { vt = j; break; }
                if (vt == -1) { vt = k; sp[k] = t[1]; k++; }
                dt[vt] += long.Parse(t[2]) * long.Parse(t[3]);
            }
            sanPham = new string[k]; doanhThu = new long[k];
            Array.Copy(sp, sanPham, k); Array.Copy(dt, doanhThu, k);
        }
    }
}
