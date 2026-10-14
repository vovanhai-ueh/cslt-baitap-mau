/*
 * Bài    : Buoi06_B8 – Tần suất xuất hiện
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi06_B8
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

        static void DemTanSuat(int[] a, out int[] giaTri, out int[] soLan)
        {
            int[] gt = new int[a.Length], sl = new int[a.Length];
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                bool daCo = false;
                for (int j = 0; j < i; j++) if (a[j] == a[i]) { daCo = true; break; }
                if (daCo) continue;
                int dem = 0;
                for (int j = i; j < a.Length; j++) if (a[j] == a[i]) dem++;
                gt[k] = a[i]; sl[k] = dem; k++;
            }
            giaTri = new int[k]; soLan = new int[k];
            Array.Copy(gt, giaTri, k); Array.Copy(sl, soLan, k);
        }
    }
}
