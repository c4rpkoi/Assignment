using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class VnVaccineService
    {
        private List<VnVaccine> _VnVaccineLst;
        private VnVaccine _VnVaccine;

        public VnVaccineService()
        {
            FakeData();
        }
        public void FakeData()
        {
            _VnVaccineLst = new List<VnVaccine>()
            {
                new VnVaccine("1","Vaccine1","NSX1",2020,2,"Công nghệ lõi",16,""),
                new VnVaccine("2","Vaccine2","NSX2",2021,3,"Công nghệ B",16,"Sốt sau tiêm"),
                new VnVaccine("3","Vaccine3","NSX3",2020,1,"Công nghệ C",12,""),
                new VnVaccine("4","Vaccine4","NSX4",2019,6,"Công nghệ B",1,""),
                new VnVaccine("5","Vaccine5","NSX5",2021,18,"Công nghệ X",3,"Viêm họng nhẹ"),
                new VnVaccine("6","Vaccine6","NSX1",2022,6,"Công nghệ Y",6,""),
                new VnVaccine("7","Vaccine7","NSX3",2020,2,"Công nghệ A",9,"Chống chỉ địnhs mẫn cảm với thành phần"),
                new VnVaccine("8","Vaccine8","NSX6",2019,2,"Công nghệ lõi",18,""),
                new VnVaccine("9","Vaccine9","NSX4",2018,7,"Công nghệ lõi",16,""),
                new VnVaccine("10","Vaccine10","NSX8",2010,14,"Công nghệ lõi",16,""),
            };
        }

        public void Them()
        {
            Console.WriteLine("Mời nhập sl: ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                _VnVaccine = new VnVaccine();
                Console.WriteLine("Mời bạn nhập Mã: ");
                _VnVaccine.MaVCC = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập tên: ");
                _VnVaccine.TenVCC = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập Nhà sản xuất: ");
                _VnVaccine.NhaSX = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập năm sản xuất");
                _VnVaccine.NamSX = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập Thời gian tác dụng: ");
                _VnVaccine.ThoiGianTacDung = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập Công nghệ: ");
                _VnVaccine.CongNghe = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập Tuổi được tiêm: ");
                _VnVaccine.TuoiDuocPhepTiem = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập ghi chú: ");
                _VnVaccine.Ghichu = Console.ReadLine();
                _VnVaccineLst.Add(_VnVaccine);
            }
        }
        public void Xoa()
        {
            Console.WriteLine("Mời bạn nhập MãVCC: ");
            string ma = Console.ReadLine();
            for (int i = 0; i < _VnVaccineLst.Count; i++)
            {
                if (_VnVaccineLst[i].MaVCC == ma)
                {
                    _VnVaccineLst.RemoveAt(i);
                    return;
                }
            }
            Console.WriteLine("Không tìm thấy");
        }
        public void Sua()
        {
            Console.WriteLine("Mời bạn nhập MãVCC: ");
            string ma = Console.ReadLine();
            for (int i = 0; i < _VnVaccineLst.Count; i++)
            {
                if (_VnVaccineLst[i].MaVCC == ma)
                {
                    Console.WriteLine("Mời bạn nhập Mã: ");
                    _VnVaccineLst[i].MaVCC = Console.ReadLine();
                    Console.WriteLine("Mời bạn nhập tên: ");
                    _VnVaccineLst[i].TenVCC = Console.ReadLine();
                    Console.WriteLine("Mời bạn nhập Nhà sản xuất: ");
                    _VnVaccineLst[i].NhaSX = Console.ReadLine();
                    Console.WriteLine("Mời bạn nhập năm sản xuất");
                    _VnVaccineLst[i].NamSX = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Mời bạn nhập Thời gian tác dụng: ");
                    _VnVaccineLst[i].ThoiGianTacDung = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Mời bạn nhập Công nghệ: ");
                    _VnVaccineLst[i].CongNghe = Console.ReadLine();
                    Console.WriteLine("Mời bạn nhập Tuổi được tiêm: ");
                    _VnVaccineLst[i].TuoiDuocPhepTiem = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Mời bạn nhập ghi chú: ");
                    _VnVaccineLst[i].Ghichu = Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Không tìm thấy");
        }
        public void InDs()
        {
            foreach (var x in _VnVaccineLst)
            {
                x.InRaManHinh();
            }
        }
        public void SapXep()
        {
            Console.WriteLine("1 Tăng dần theo mã\n 2 Giảm dần theo mã");
            int chon = Convert.ToInt32(Console.ReadLine());
            if (chon==1)
            {
                _VnVaccineLst = _VnVaccineLst.OrderBy(p => p.MaVCC).ToList();
            }else if (chon == 2)
            {
                _VnVaccineLst = _VnVaccineLst.OrderByDescending(p => p.MaVCC).ToList();

            }
        }
    }
    }
