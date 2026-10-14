/*
 * Bài    : Buoi08_A3 – Nhật ký có ghi thêm
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi08_A3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Ghi chép hôm nay: ");
            string noiDung = Console.ReadLine();
            string dong = DateTime.Now.ToString("dd/MM/yyyy HH:mm") + " - " + noiDung;
            using (StreamWriter sw = new StreamWriter("nhatky.txt", true))
            {
                sw.WriteLine(dong);
            }
            string[] tatCa = File.ReadAllLines("nhatky.txt");
            int batDau = Math.Max(0, tatCa.Length - 3);
            Console.WriteLine("3 ghi chép mới nhất:");
            for (int i = batDau; i < tatCa.Length; i++)
                Console.WriteLine("  " + tatCa[i]);
        }
    }
}
