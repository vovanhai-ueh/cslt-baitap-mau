/*
 * Bài    : Buoi01_A5 – Từ lưu đồ đến chương trình
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi01_A5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double a = 5, b = 3;
            double cv = 2 * (a + b);
            double dt = a * b;
            Console.WriteLine("Chiều dài  = " + a);
            Console.WriteLine("Chiều rộng = " + b);
            Console.WriteLine("Chu vi     = " + cv);
            Console.WriteLine("Diện tích  = " + dt);
        }
    }
}
