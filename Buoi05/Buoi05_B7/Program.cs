/*
 * Bài    : Buoi05_B7 – Phân tích thừa số nguyên tố
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi05_B7
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

        static string PhanTichThuaSo(int n)
        {
            string kq = "";
            for (int p = 2; p * p <= n; p++)
                while (n % p == 0) { kq += (kq == "" ? "" : " x ") + p; n /= p; }
            if (n > 1) kq += (kq == "" ? "" : " x ") + n;
            return kq;
        }
    }
}
