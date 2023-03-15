using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302210006
{
    internal class KodeBuah_1302210006
    {
        public enum buah {
            Apel,
            Aprikot,
            Alpukat,
            Pisang,
            Paprika,
            Blackberry,
            Ceri,
            Kelapa,
            Jagung
        }

        public static String getKodeBuah_1302210006(buah fruit) {
            string[] kode_Buah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00" };
            return kode_Buah[(int)fruit];
        }

    }
}
