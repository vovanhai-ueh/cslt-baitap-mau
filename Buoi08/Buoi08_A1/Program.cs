/*
 * Bài    : Buoi08_A1 – Ghi và đọc tệp với lớp File
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi08_A1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            string[] ten = new string[50];
            int n = 0;
            while (n < ten.Length)
            {
                Console.Write($"Tên thứ {n + 1} (Enter để dừng): ");
                string s = Console.ReadLine();
                if (s == null || s.Trim() == "") break;
                ten[n++] = s.Trim();
            }
            File.WriteAllLines("ds.txt", ten[..n]);
            string[] doc = File.ReadAllLines("ds.txt");
            for (int i = 0; i < doc.Length; i++)
                Console.WriteLine($"{i + 1}. {doc[i]}");
        }
    }
}
