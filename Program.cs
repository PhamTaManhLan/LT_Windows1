using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapVeNhaSo2
{
    public class HocSinh
    {
        public int MaSo { get; set; }
        public string Ten { get; set; }
        public int Tuoi { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Đặt encoding cho UTF-8 để hiển thị tiếng Việt
            Console.OutputEncoding = Encoding.UTF8;

            // Nhập số lượng học sinh từ người dùng
            Console.Write("Nhập số lượng học sinh: ");
            int soLuongHocSinh = int.Parse(Console.ReadLine());

            // Tạo danh sách học sinh
            List<HocSinh> danhSachHocSinh = new List<HocSinh>();

            // Yêu cầu người dùng nhập thông tin số lượng học sinh vừa nhập
            for (int i = 0; i < soLuongHocSinh; i++)
            {
                Console.WriteLine($"\nNhập thông tin học sinh thứ {i + 1}:");

                int maSo;
                while (true)
                {
                    Console.Write("Mã số học sinh: ");
                    if (int.TryParse(Console.ReadLine(), out maSo)) break;
                    Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ.");
                }

                Console.Write("Tên học sinh: ");
                string ten = Console.ReadLine();

                int tuoi;
                while (true)
                {
                    Console.Write("Tuổi học sinh: ");
                    if (int.TryParse(Console.ReadLine(), out tuoi)) break;
                    Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ.");
                }

                danhSachHocSinh.Add(new HocSinh { MaSo = maSo, Ten = ten, Tuoi = tuoi });
            }

            bool thoat = false;

            while (!thoat)
            {
                // Hiển thị menu
                Console.WriteLine("\nChọn nhiệm vụ muốn thực hiện:");
                Console.WriteLine("1. In danh sách toàn bộ học sinh");
                Console.WriteLine("2. Tìm học sinh có tuổi từ 15 đến 18");
                Console.WriteLine("3. Tìm học sinh có tên bắt đầu bằng chữ 'A'");
                Console.WriteLine("4. Tính tổng tuổi của tất cả học sinh");
                Console.WriteLine("5. Tìm học sinh có tuổi lớn nhất");
                Console.WriteLine("6. Sắp xếp danh sách học sinh theo tuổi tăng dần");
                Console.WriteLine("7. Thoát");

                Console.Write("\nLựa chọn của bạn: ");
                string luaChon = Console.ReadLine();

                switch (luaChon)
                {
                    case "1":
                        // In danh sách toàn bộ học sinh
                        Console.WriteLine("\nDanh sách toàn bộ học sinh:");
                        danhSachHocSinh.ForEach(hs => Console.WriteLine($"Mã số: {hs.MaSo}, Tên: {hs.Ten}, Tuổi: {hs.Tuoi}"));
                        break;

                    case "2":
                        // Tìm học sinh có tuổi từ 15 đến 18
                        Console.WriteLine("\nHọc sinh có tuổi từ 15 đến 18:");
                        var hocSinhTu15Den18 = danhSachHocSinh.Where(hs => hs.Tuoi >= 15 && hs.Tuoi <= 18).ToList();
                        if (hocSinhTu15Den18.Count == 0)
                        {
                            Console.WriteLine("Không có học sinh nào trong độ tuổi từ 15 đến 18.");
                        }
                        else
                        {
                            hocSinhTu15Den18.ForEach(hs => Console.WriteLine($"Mã số: {hs.MaSo}, Tên: {hs.Ten}, Tuổi: {hs.Tuoi}"));
                        }
                        break;

                    case "3":
                        // Tìm học sinh có tên bắt đầu bằng chữ "A"
                        Console.WriteLine("\nHọc sinh có tên bắt đầu bằng chữ 'A':");
                        var hocSinhBatDauBangA = danhSachHocSinh.Where(hs => hs.Ten.StartsWith("A")).ToList();
                        if (hocSinhBatDauBangA.Count == 0)
                        {
                            Console.WriteLine("Không có học sinh nào có tên bắt đầu bằng chữ 'A'.");
                        }
                        else
                        {
                            hocSinhBatDauBangA.ForEach(hs => Console.WriteLine($"Mã số: {hs.MaSo}, Tên: {hs.Ten}, Tuổi: {hs.Tuoi}"));
                        }
                        break;

                    case "4":
                        // Tính tổng tuổi của tất cả học sinh
                        var tongTuoi = danhSachHocSinh.Sum(hs => hs.Tuoi);
                        Console.WriteLine($"\nTổng tuổi của tất cả học sinh: {tongTuoi}");
                        break;

                    case "5":
                        // Tìm học sinh có tuổi lớn nhất
                        var hocSinhLonNhat = danhSachHocSinh.OrderByDescending(hs => hs.Tuoi).FirstOrDefault();
                        if (hocSinhLonNhat != null)
                        {
                            Console.WriteLine($"\nHọc sinh có tuổi lớn nhất: Mã số: {hocSinhLonNhat.MaSo}, Tên: {hocSinhLonNhat.Ten}, Tuổi: {hocSinhLonNhat.Tuoi}");
                        }
                        break;

                    case "6":
                        // Sắp xếp danh sách học sinh theo tuổi tăng dần
                        Console.WriteLine("\nDanh sách học sinh theo tuổi tăng dần:");
                        var danhSachSapXepTheoTuoi = danhSachHocSinh.OrderBy(hs => hs.Tuoi).ToList();
                        danhSachSapXepTheoTuoi.ForEach(hs => Console.WriteLine($"Mã số: {hs.MaSo}, Tên: {hs.Ten}, Tuổi: {hs.Tuoi}"));
                        break;

                    case "7":
                        // Thoát chương trình
                        thoat = true;
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
            }

            // Dừng chương trình để chờ người dùng nhấn phím, tránh việc tắt chương trình ngay lập tức
            Console.WriteLine("\nNhấn Enter để thoát chương trình.");
            Console.ReadLine();
        }
    }
}
