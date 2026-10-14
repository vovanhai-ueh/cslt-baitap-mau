/*
 * Bài    : Buoi05_A6 – Trò chơi đoán số
 * Họ tên : [điền họ tên]
 * MSSV   : [điền MSSV]
 */
using System.Globalization;

namespace Buoi05_A6
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

        static int NhapSoNguyenTrongKhoang(string loiNhac, int min, int max)
        {
            int x;
            bool hopLe;
            do
            {
                Console.Write(loiNhac);
                hopLe = int.TryParse(Console.ReadLine(), out x) && x >= min && x <= max;
                if (!hopLe)
                    Console.WriteLine($"  Không hợp lệ, hãy nhập số nguyên từ {min} đến {max}.");
            } while (!hopLe);
            return x;
        }

        static bool ChoiMotVan(int soBiMat, int soLuotToiDa)
        {
            for (int luot = 1; luot <= soLuotToiDa; luot++)
            {
                int doan = NhapSoNguyenTrongKhoang($"Lượt {luot}/{soLuotToiDa} - đoán: ", 1, 100);
                if (doan == soBiMat)
                {
                    Console.WriteLine($"Chính xác! Bạn đoán đúng sau {luot} lượt.");
                    return true;
                }
                Console.WriteLine(doan < soBiMat ? "  Lớn hơn!" : "  Nhỏ hơn!");
            }
            Console.WriteLine($"Hết lượt! Số bí mật là {soBiMat}.");
            return false;
        }
    }
}
