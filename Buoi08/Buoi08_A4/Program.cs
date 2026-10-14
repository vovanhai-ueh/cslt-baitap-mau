/*
 * Bài    : Buoi08_A4 – Lưu và đọc ma trận
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi08_A4
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

        static void GhiMaTran(string duongDan, int[,] a)
        {
            int m = a.GetLength(0), n = a.GetLength(1);
            using (StreamWriter sw = new StreamWriter(duongDan))
            {
                sw.WriteLine($"{m} {n}");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++) sw.Write(a[i, j] + (j < n - 1 ? " " : ""));
                    sw.WriteLine();
                }
            }
        }

        static int[,] DocMaTran(string duongDan)
        {
            using (StreamReader sr = new StreamReader(duongDan))
            {
                string[] kt = sr.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int m = int.Parse(kt[0]), n = int.Parse(kt[1]);
                int[,] a = new int[m, n];
                for (int i = 0; i < m; i++)
                {
                    string[] t = sr.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < n; j++) a[i, j] = int.Parse(t[j]);
                }
                return a;
            }
        }
    }
}
