using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class VnVaccine:Vaccine
    {
        public string CongNghe { get; set; }
        public int TuoiDuocPhepTiem { get; set; }
        public string Ghichu { get; set; }

        public VnVaccine()
        {

        }

        public VnVaccine(string maVCC, string tenVCC, string nhaSX, int namSX, int thoiGianTacDung, string congNghe, int tuoiDuocPhepTiem, string ghichu) : base(maVCC, tenVCC, nhaSX, namSX, thoiGianTacDung)
        {
            CongNghe = congNghe;
            TuoiDuocPhepTiem = tuoiDuocPhepTiem;
            Ghichu = ghichu;
        }

        public override void InRaManHinh()
        {
            Console.WriteLine($"Mã: {MaVCC}, Tên: {TenVCC}, NSX: {NhaSX},NămSX: {NamSX},Thời gian sử dụng: {ThoiGianTacDung}, Công nghệ: {CongNghe}, Tuổi đc tiêm: {TuoiDuocPhepTiem}, Ghi chú: {Ghichu}");
        }
    }
}
