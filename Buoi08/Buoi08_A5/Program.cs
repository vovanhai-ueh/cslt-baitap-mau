/*
 * Bài    : Buoi08_A5 – Đọc tệp an toàn với try-catch
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi08_A5
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

        static bool DocMangAnToan(string duongDan, out int[] a)
        {
            a = null;
            try
            {
                string[] dong = File.ReadAllLines(duongDan);
                a = new int[dong.Length];
                for (int i = 0; i < dong.Length; i++) a[i] = int.Parse(dong[i]);
                return true;
            }
            catch (FileNotFoundException) { Console.WriteLine($"Không tìm thấy tệp {duongDan}."); }
            catch (FormatException) { Console.WriteLine($"Tệp {duongDan} có dòng không phải số nguyên."); }
            a = null;
            return false;
        }
    }
}
