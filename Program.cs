﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PemrogramanResponsi2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan kry1 = new Karyawan();

            kry1.Nik = "18112260";
            kry1.Nama = "nalendra harva m";
            kry1.GajiBulanan = 2000000;

            Karyawan kry2 = new Karyawan();

            kry2.Nik = "1111111888";
            kry2.Nama = "paijo";
            kry2.GajiBulanan = 5000000;

            Console.WriteLine("No.\tNik/Nama\t\tGaji Bulanan");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("1.\t{0}  {1}\t\t{2}", kry1.Nik, kry1.Nama, kry1.GajiBulanan);
            Console.WriteLine("2.\t{0}  {1}\t\t{2}", kry2.Nik, kry2.Nama, kry2.GajiBulanan);

            Console.WriteLine("\n\n");
            Console.WriteLine("Asyiiik Kenaikan Gaji 10%");
            Console.WriteLine("\n");
            Console.WriteLine("No.\tNik/Nama\t\tGaji Bulanan");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("1.\t{0}  {1}\t\t{2}", kry1.Nik, kry1.Nama, kry1.GajiBulanan + (kry1.GajiBulanan * 0.10));
            Console.WriteLine("2.\t{0}  {1}\t\t{2}", kry2.Nik, kry2.Nama, kry2.GajiBulanan + (kry2.GajiBulanan * 0.10));
        }

    }
}
