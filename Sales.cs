using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Tugaslab9
{
    class Sales : Karyawan
    {
        public double jumlahjual { get; set; }
        public double komisi { get; set; }
        public override double gaji()
        {
            return jumlahjual * komisi;
        }
    }
}
