﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_FP
{
    public abstract class BangunDatar
    {
        public string noBangun { get; set; }
        public abstract double Keliling();
        public abstract double Luas();

    }
}
