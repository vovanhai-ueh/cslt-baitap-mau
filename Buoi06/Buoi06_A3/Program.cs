/*
 * Bài    : Buoi06_A3 – Đảo mảng và mảng đối xứng
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi06_A3
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

        static void DaoMang(int[] a)
        {
            for (int i = 0, j = a.Length - 1; i < j; i++, j--)
            {
                int tam = a[i]; a[i] = a[j]; a[j] = tam;
            }
        }

        static bool LaMangDoiXung(int[] a)
        {
            for (int i = 0; i < a.Length / 2; i++)
                if (a[i] != a[a.Length - 1 - i]) return false;
            return true;
        }
    }
}
