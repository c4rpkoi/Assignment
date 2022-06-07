﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal abstract class Vaccine
    {
        public string MaVCC { get; set; }
        public string TenVCC { get; set; }

        public string NhaSX { get; set; }
        public int NamSX { get; set; }
        public int ThoiGianTacDung { get; set; }

        public Vaccine()
        {

        }

        public Vaccine(string maVCC, string tenVCC, string nhaSX, int namSX, int thoiGianTacDung)
        {
            MaVCC = maVCC;
            TenVCC = tenVCC;
            NhaSX = nhaSX;
            NamSX = namSX;
            ThoiGianTacDung = thoiGianTacDung;
        }

        public abstract void InRaManHinh();
    }
}
