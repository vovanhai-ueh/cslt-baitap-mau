/*
 * Bài    : Buoi06_A5 – Sắp xếp chọn và tìm kiếm nhị phân
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi06_A5
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

        static int SapXepChon(int[] a)
        {
            int soSoSanh = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                int vtMin = i;
                for (int j = i + 1; j < a.Length; j++) { soSoSanh++; if (a[j] < a[vtMin]) vtMin = j; }
                int tam = a[i]; a[i] = a[vtMin]; a[vtMin] = tam;
            }
            return soSoSanh;
        }

        static int TimNhiPhan(int[] a, int x, out int soBuoc)
        {
            int trai = 0, phai = a.Length - 1;
            soBuoc = 0;
            while (trai <= phai)
            {
                soBuoc++;
                int giua = (trai + phai) / 2;
                if (a[giua] == x) return giua;
                if (a[giua] < x) trai = giua + 1; else phai = giua - 1;
            }
            return -1;
        }
    }
}
