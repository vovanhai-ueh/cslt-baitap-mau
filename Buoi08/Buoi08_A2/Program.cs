/*
 * Bài    : Buoi08_A2 – Thống kê tệp số với StreamReader
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi08_A2
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

        static void ThongKeTep(string duongDan)
        {
            int soHopLe = 0, soLoi = 0;
            double tong = 0, max = double.MinValue, min = double.MaxValue;
            using (StreamReader sr = new StreamReader(duongDan))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Trim() == "") continue;
                    if (!double.TryParse(line, out double x)) { soLoi++; continue; }
                    soHopLe++;
                    tong += x;
                    if (x > max) max = x;
                    if (x < min) min = x;
                }
            }
            if (soHopLe == 0) { Console.WriteLine("Tệp không có số hợp lệ."); return; }
            Console.WriteLine($"Số hợp lệ: {soHopLe}, dòng lỗi: {soLoi}");
            Console.WriteLine($"Tổng = {tong}, TB = {tong / soHopLe:F2}, max = {max}, min = {min}");
        }
    }
}
