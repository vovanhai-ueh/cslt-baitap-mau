/*
 * Bài    : Buoi04_A2 – Xếp loại học lực có kiểm tra điểm
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi04_A2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Nhập điểm trung bình (0–10): ");
            string s = Console.ReadLine();
            if (!double.TryParse(s, out double diem) || diem < 0 || diem > 10)
            {
                Console.WriteLine("Dữ liệu không hợp lệ.");
                return;
            }
            Console.WriteLine($"Xếp loại: {XepLoai(diem)}");
        }

        static string XepLoai(double diem)
        {
            if (diem >= 8) return "Giỏi";
            else if (diem >= 6.5) return "Khá";
            else if (diem >= 5) return "Trung bình";
            else return "Yếu";
        }
    }
}
