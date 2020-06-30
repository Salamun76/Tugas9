using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tugaslab9
{
    public abstract class Karyawan
    {
        public string NIK { get; set; }
        public string NAMA { get; set; }
        public abstract double gaji();
    }
}
