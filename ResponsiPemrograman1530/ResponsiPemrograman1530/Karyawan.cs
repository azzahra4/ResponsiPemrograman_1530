using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman1530
{
    public class Karyawan
    {

        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

        public void informasiKaryawan()
        {
            if (GajiBulanan < 1)
            {
                Console.WriteLine("Gaji Bulanan Tidak Masuk Akal");
            }
            else
            {
                Console.WriteLine("No NIK/Nama              Gaji Bulanan");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("1. {0}/{1}             Rp.{2:#,0}", Nik, Nama, GajiBulanan);
                naikGaji();
            }
        }

        public void naikGaji()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Asyiiiik kenaikan gaji 10%");
            int naik = (GajiBulanan / 100) * 10;
            int hasilAkhir = naik + GajiBulanan;
            Console.WriteLine("No NIK/Nama              Gaji Bulanan");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1. {0}/{1}             Rp.{2:#,0}", Nik, Nama, hasilAkhir);
        }
    }
}
