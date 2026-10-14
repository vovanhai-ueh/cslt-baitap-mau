/*
 * Bài    : Buoi08_A6 – Bảng điểm lưu bằng CSV
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi08_A6
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

        static void GhiBangDiem(string duongDan, string[] mssv, double[,] diem)
        {
            using (StreamWriter sw = new StreamWriter(duongDan))
            {
                sw.WriteLine("MSSV,Toan,Ly,Tin");
                for (int i = 0; i < mssv.Length; i++)
                {
                    sw.Write(mssv[i]);
                    for (int j = 0; j < diem.GetLength(1); j++) sw.Write("," + diem[i, j].ToString(CultureInfo.InvariantCulture));
                    sw.WriteLine();
                }
            }
        }

        static void DocBangDiem(string duongDan, out string[] mssv, out double[,] diem)
        {
            string[] dong = File.ReadAllLines(duongDan);
            int soSV = dong.Length - 1;
            mssv = new string[soSV];
            diem = new double[soSV, 3];
            for (int i = 0; i < soSV; i++)
            {
                string[] t = dong[i + 1].Split(',');
                mssv[i] = t[0];
                for (int j = 0; j < 3; j++) diem[i, j] = double.Parse(t[j + 1], CultureInfo.InvariantCulture);
            }
        }
    }
}
