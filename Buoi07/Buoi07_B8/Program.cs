/*
 * Bài    : Buoi07_B8 – Trò chơi dò mìn
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi07_B8
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

        static string[] DoMin(string[] banDo)
        {
            int soDong = banDo.Length;
            string[] kq = new string[soDong];
            for (int i = 0; i < soDong; i++)
            {
                string dong = "";
                for (int j = 0; j < banDo[i].Length; j++)
                {
                    if (banDo[i][j] == '*') { dong += '*'; continue; }
                    int dem = 0;
                    for (int di = -1; di <= 1; di++)
                        for (int dj = -1; dj <= 1; dj++)
                        {
                            int u = i + di, w = j + dj;
                            if (u >= 0 && u < soDong && w >= 0 && w < banDo[u].Length && banDo[u][w] == '*') dem++;
                        }
                    dong += dem.ToString();
                }
                kq[i] = dong;
            }
            return kq;
        }
    }
}
