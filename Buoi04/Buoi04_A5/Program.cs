/*
 * Bài    : Buoi04_A5 – Máy tính bỏ túi
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi04_A5
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

        static string TinhToan(double a, char phepToan, double b)
        {
            switch (phepToan)
            {
                case '+': return $"{a} + {b} = {a + b}";
                case '-': return $"{a} - {b} = {a - b}";
                case '*': return $"{a} * {b} = {a * b}";
                case '/':
                    if (b == 0) return "Lỗi: không chia được cho 0";
                    return $"{a} / {b} = {a / b}";
                case '%':
                    if (b == 0) return "Lỗi: không chia được cho 0";
                    return $"{a} % {b} = {a % b}";
                case '^': return $"{a} ^ {b} = {Math.Pow(a, b)}";
                default: return $"Phép toán '{phepToan}' không được hỗ trợ";
            }
        }
    }
}
