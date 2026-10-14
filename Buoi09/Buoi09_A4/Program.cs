/*
 * Bài    : Buoi09_A4 – List<T> và Dictionary<K, V>
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi09_A4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            List<int> L = new List<int> { 5, 3, 8 };
            L.Add(1);
            L.RemoveAt(0);
            L.Insert(0, 9);
            Console.WriteLine(string.Join(" ", L) + " " + L.Count + " " + L.Sum());
            Dictionary<string, double> diem = new Dictionary<string, double>();
            diem["SV01"] = 6.8;
            diem["SV02"] = 9.1;
            diem["SV01"] = 7.0;
            Console.WriteLine(diem.Count + " " + diem["SV01"] + " " + diem.ContainsKey("SV09"));
            if (diem.TryGetValue("SV02", out double d))
                Console.WriteLine(d);
            foreach (KeyValuePair<string, double> kv in diem)
                Console.Write($"{kv.Key}={kv.Value} ");
            Console.WriteLine();
        }
    }
}
