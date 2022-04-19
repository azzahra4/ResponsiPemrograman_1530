using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman1530
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarasi Variabel
            Karyawan karyawan = new Karyawan();
            Console.WriteLine("Masukkan NIK Karyawan");
            string Nik = Console.ReadLine();
            karyawan.Nik = Nik;
            Console.WriteLine("Masukkan Nama Karyawan");
            string Nama = Console.ReadLine();
            karyawan.Nama = Nama;
            Console.WriteLine("Masukkan Gaji Karyawan");
            int GajiBulanan = int.Parse(Console.ReadLine());
            karyawan.GajiBulanan = GajiBulanan;


            karyawan.informasiKaryawan();
        }
    }
}
