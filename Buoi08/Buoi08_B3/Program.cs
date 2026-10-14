/*
 * Bài    : Buoi08_B3 – Lọc số nguyên tố từ tệp
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi08_B3
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

        static bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;
            return true;
        }

        static int LocSoNguyenTo(string nguon, string dich)
        {
            int dem = 0;
            using (StreamReader sr = new StreamReader(nguon))
            using (StreamWriter sw = new StreamWriter(dich))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                    if (int.TryParse(line.Trim(), out int x) && LaSoNguyenTo(x)) { sw.WriteLine(x); dem++; }
            }
            return dem;
        }
    }
}
