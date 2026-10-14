/*
 * Bài    : Buoi04_B2 – Phân loại BMI
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi04_B2
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

        static double TinhBMI(double canNang, double chieuCao)
        {
            return canNang / (chieuCao * chieuCao);
        }

        static string PhanLoaiBMI(double bmi)
        {
            if (bmi < 18.5) return "Gầy";
            if (bmi < 25) return "Bình thường";
            if (bmi < 30) return "Thừa cân";
            return "Béo phì";
        }
    }
}
