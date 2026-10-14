/*
 * Bài    : Buoi08_B7 – Mã hóa Caesar tệp văn bản
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi08_B7
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

        static string MaHoaCaesar(string s, int k)
        {
            k = ((k % 26) + 26) % 26;
            char[] kq = s.ToCharArray();
            for (int i = 0; i < kq.Length; i++)
            {
                char c = kq[i];
                if (c >= 'a' && c <= 'z') kq[i] = (char)('a' + (c - 'a' + k) % 26);
                else if (c >= 'A' && c <= 'Z') kq[i] = (char)('A' + (c - 'A' + k) % 26);
            }
            return new string(kq);
        }

        static void MaHoaTep(string nguon, string dich, int k)
        {
            using (StreamReader sr = new StreamReader(nguon))
            using (StreamWriter sw = new StreamWriter(dich))
            {
                string line;
                while ((line = sr.ReadLine()) != null) sw.WriteLine(MaHoaCaesar(line, k));
            }
        }
    }
}
