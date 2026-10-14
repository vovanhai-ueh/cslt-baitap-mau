/*
 * Bài    : Buoi09_B7 – Lớp MaTran có toán tử + và *
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi09_B7
{
    class MaTran
    {
        public int[,] DuLieu { get; }

        public MaTran(int[,] duLieu) { DuLieu = duLieu; }

        public static MaTran operator +(MaTran x, MaTran y)
        {
            int m = x.DuLieu.GetLength(0), n = x.DuLieu.GetLength(1);
            if (y.DuLieu.GetLength(0) != m || y.DuLieu.GetLength(1) != n)
                throw new ArgumentException("Hai ma trận phải cùng kích thước");
            int[,] c = new int[m, n];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++) c[i, j] = x.DuLieu[i, j] + y.DuLieu[i, j];
            return new MaTran(c);
        }

        public static MaTran operator *(MaTran x, MaTran y)
        {
            int m = x.DuLieu.GetLength(0), n = x.DuLieu.GetLength(1), p = y.DuLieu.GetLength(1);
            if (y.DuLieu.GetLength(0) != n)
                throw new ArgumentException("Số cột ma trận trái phải bằng số dòng ma trận phải");
            int[,] c = new int[m, p];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < p; j++)
                    for (int k = 0; k < n; k++) c[i, j] += x.DuLieu[i, k] * y.DuLieu[k, j];
            return new MaTran(c);
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < DuLieu.GetLength(0); i++)
            {
                for (int j = 0; j < DuLieu.GetLength(1); j++) s += $"{DuLieu[i, j],5}";
                s += "\n";
            }
            return s;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            // Gọi thử các hàm của em ở đây, ví dụ:
            // Console.WriteLine(TenHam(...));
        }
    }
}
