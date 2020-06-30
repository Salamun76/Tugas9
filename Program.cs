using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Tugaslab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 9 - Polymorphsim, Inheritance, Abstraction & Collection";
            List<Karyawan> listKaryawan = new List<Karyawan>();
            int pilihan;
            do
            {
             Console.Clear();
             Console.WriteLine("Pilih Menu Aplikasi");
             Console.WriteLine();
             Console.WriteLine("1. Tambah Data Karyawan");
             Console.WriteLine("2. Hapus Data Karyawan");
             Console.WriteLine("3. Tampilkan Data Karyawan");
             Console.WriteLine("4. Selesai");
             Console.WriteLine();
             Console.Write("Nomor Menu [1..4] : ");
             pilihan = Convert.ToInt32(Console.ReadLine());
             Console.Clear();
             switch (pilihan)
                {
                case 1:
                 Console.WriteLine("Tambah Data Karyawan\n");
                 Console.Write("Pilih Jenis Karyawan [1.Karyawan Tetap - 2.Karyawan Harian - 3.Sales] : ");
                 int pil = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine();
                 switch (pil)
                 {
                    case 1:
                    KaryawanTetap karyawanTetap = new KaryawanTetap();
                    Console.Write("NIK : ");
                    karyawanTetap.NIK = Console.ReadLine();
                    Console.Write("Nama : ");
                    karyawanTetap.NAMA = Console.ReadLine();
                    Console.Write("Gaji Bulanan : ");
                    karyawanTetap.Gajiperbulan = Convert.ToDouble(Console.ReadLine());
                    listKaryawan.Add(karyawanTetap);
                    break;
                    
                    case 2:
                    KaryawanHarian karyawanHarian = new KaryawanHarian();
                    Console.Write("NIK : ");
                    karyawanHarian.NIK = Console.ReadLine();
                    Console.Write("Nama : ");
                    karyawanHarian.NAMA = Console.ReadLine();
                    Console.Write("Jumlah Jam Kerja : ");
                    karyawanHarian.jamkerja = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Upah Per Jam : ");
                    karyawanHarian.gajiperjam = Convert.ToDouble(Console.ReadLine());
                    listKaryawan.Add(karyawanHarian);
                    break;
                    
                    case 3:
                    Sales sales = new Sales();
                    Console.Write("NIK : ");
                    sales.NIK = Console.ReadLine();
                    Console.Write("Nama : ");
                    sales.NAMA = Console.ReadLine();
                    Console.Write("Jumlah Jam Kerja : ");
                    sales.jumlahjual = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Upah Per Jam : ");
                    sales.komisi = Convert.ToDouble(Console.ReadLine());
                    listKaryawan.Add(sales);
                    break;
                    
                    default:
                    Console.WriteLine("MENU TIDAK ADA");
                    break;
                
                     
                 }
                    break;
                    
              case 2:
               Console.WriteLine("Hapus Data Karyawan\n");
               Console.Write("NIK : ");
               string nik = Console.ReadLine();
               int urutan = -1, hapus = -1;
               foreach (Karyawan karyawan in listKaryawan)
                    {
                        urutan++;
                        if(karyawan.NIK == nik)
                        {
                            hapus = urutan;
                        }
                    }
                        
                        if (hapus != -1)
                        
                        {
                            listKaryawan.RemoveAt(hapus);
                            Console.WriteLine("\nData Dihapus");
                        }
                        
                        else
                        {
                            Console.WriteLine("\nData Nik tidak ditemukan");
                        }
                        
                        break;
              case 3:
               int nomor = 0;
               string jenis=" ";
               Console.WriteLine("Data Karyawan\n");
               foreach (Karyawan karyawan in listKaryawan)
                        {
                            if(karyawan is KaryawanTetap)
                            {
                                jenis = "Karyawan Tetap";
                            }
                            
                            else if(karyawan is KaryawanHarian)
                            {
                                jenis = "Karyawan Harian";
                            }
                            
                            else
                            {
                                jenis = "Sales";
                            }
                            
                        nomor++;
                        Console.WriteLine("{0}. NIK: {1}, NAMA: {2}, gaji: {3:N0}, {4}", nomor, karyawan.NIK, karyawan.NAMA, karyawan.gaji(), jenis);
                        }
                        
                        if (nomor < 1)
                            {
                                Console.WriteLine("Data Karyawan Kosong");
                            }

                        break;
              case 4:
               break;
               default:
               Console.WriteLine("MENU TIDAK ADA");
               break;

                }

                Console.WriteLine("\n\nTekan Enter untuk kembali ke Menu");
                Console.ReadKey();

            }

            while (pilihan != 4);
        }
    }
}