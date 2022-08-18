using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_FP
{
    class Program
    {
        static List<BangunDatar> bangundatar = new List<BangunDatar>();
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Perhitungan Bangun Datar";
            bool loop = true;
            while (loop)
            {
                DisplayMenu();

                Console.Write("\nNomor Menu [1..5]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahBangun();
                        break;

                    case 2:
                        HapusBangun();
                        break;

                    case 3:
                        TampilBangun();
                        break;

                    case 4:
                        JumlahBangun();
                        break;
                    
                    case 5:
                        loop = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
                        break;
                }
            }
        }

        static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih menu Aplikasi");
            Console.WriteLine("\n1. Tambah Bangun Datar");
            Console.WriteLine("2. Hapus Bangun Datar");
            Console.WriteLine("3. Tampilkan Bangun Datar");
            Console.WriteLine("4. Jumlahkan Luas Bangun Datar");
            Console.WriteLine("5. Keluar");
        }

        static void TambahBangun()
        {
            Console.Clear();

            BangunDatar bangun = new BangunDatar();
            Console.WriteLine("Tambah Bangun Datar");
            Console.WriteLine("\nBentuk Bangun Datar");
            Console.WriteLine("1. Persegi");
            Console.WriteLine("2. Persegi Panjang");
            Console.WriteLine("3. Trapesium Sama Kaki");
            Console.WriteLine("4. Segitiga Sama Sisi");
            Console.WriteLine("5. Belah Ketupat");
            Console.WriteLine("6. Layang - layang");
            Console.WriteLine("7. Lingkaran");
            int pil = int.Parse(Console.ReadLine());
            switch(pil)
            {
                case 1:
                    Console.Write("Persegi\n");
                    Persegi persegi = new Persegi();
                    Console.Write("Masukan Sisi : ");
                    persegi.Sisi = double.Parse(Console.ReadLine());
                    bangundatar.Add(persegi);
                    break;
                case 2:
                    Console.Write("Persegi Panjang\n");
                    PersegiPanjang persegipanjang = new PersegiPanjang();
                    Console.Write("Masukan Panjang : ");
                    persegipanjang.Panjang = double.Parse(Console.ReadLine());
                    Console.Write("Masukan Lebar : ");
                    persegipanjang.Lebar = double.Parse(Console.ReadLine());
                    bangundatar.Add(persegipanjang);
                    break;
                case 3:
                    Console.Write("Trapesium\n");
                    TrapesiumSamaKaki trapesium = new TrapesiumSamaKaki();
                    Console.Write("Masukan Sisi Atas : ");
                    trapesium.SisiAtas = double.Parse(Console.ReadLine());
                    Console.Write("Masukan Sisi Bawah : ");
                    trapesium.SisiBawah = double.Parse(Console.ReadLine());
                    Console.Write("Masukan Sisi Miring : ");
                    trapesium.SisiMiring = double.Parse(Console.ReadLine());
                    Console.Write("Masukan Tinggi : ");
                    trapesium.Tinggi = double.Parse(Console.ReadLine());
                    bangundatar.Add(trapesium);
                    break;
                case 4:
                    Console.Write("Segitiga\n");
                    SegitigaSamaSisi segitiga = new SegitigaSamaSisi();
                    Console.Write("Masukan Alas : ");
                    segitiga.Alas = double.Parse(Console.ReadLine());
                    Console.Write("Masukan Tinggi : ");
                    segitiga.Tinggi = double.Parse(Console.ReadLine());
                    bangundatar.Add(segitiga);
                    break;
                case 5:
                    Console.Write("Belah Ketupat\n");
                    BelahKetupat belahKetupat = new BelahKetupat();
                    Console.Write("Masukan Sisi : ");
                    belahKetupat.Sisi = double.Parse(Console.ReadLine());
                    Console.Write("Masukan Panjang Diagonal 1 : ");
                    belahKetupat.d1 = double.Parse(Console.ReadLine());
                    Console.Write("Masukan panjang Diagonal 2 : ");
                    belahKetupat.d2 = double.Parse(Console.ReadLine());
                    bangundatar.Add(belahKetupat);
                    break;
                case 6:
                    Console.Write("Layang - layang\n");
                    LayangLayang layang = new LayangLayang();
                    Console.Write("Masukan Sisi kiri atas : ");
                    layang.Sisi1 = double.Parse(Console.ReadLine());
                    Console.Write("Masukan Sisi kanan atas : ");
                    layang.Sisi2 = double.Parse(Console.ReadLine());
                    Console.Write("Masukan Sisi kiri bawah : ");
                    layang.Sisi3 = double.Parse(Console.ReadLine());
                    Console.Write("Masukan Sisi kanan bawah : ");
                    layang.Sisi4 = double.Parse(Console.ReadLine());
                    Console.Write("Masukan Diagonal 1 : ");
                    layang.d1 = double.Parse(Console.ReadLine());
                    Console.Write("Masukan Diagonal 2 : ");
                    layang.d2 = double.Parse(Console.ReadLine());
                    bangundatar.Add(layang);
                    break;
                case 7:
                    Console.Write("Lingkaran\n");
                    Lingkaran lingkaran = new Lingkaran();
                    Console.Write("Masukan jari - jari : ");
                    lingkaran.Jarijari = double.Parse(Console.ReadLine());
                    bangundatar.Add(lingkaran);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Maaf, menu yang Anda pilih tidak tersedia");
                    break;
            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusBangun()
        {
            Console.Clear();

            int no = -1, hapus = -1;
            Console.WriteLine("Hapus Data Bangun Ruang");
            Console.Write("Nomor Bangun : ");
            string kode = Console.ReadLine();
            foreach (BangunDatar bangun in bangundatar)
            {
                no++;
                if (bangun.noBangun == kode)
                {
                    hapus = no;
                }
            }
            if (hapus != -1)
            {
                bangundatar.RemoveAt(hapus);
                Console.WriteLine("\nData bangun datar berhasil di hapus");
            }
            else
            {
                Console.WriteLine("\nNomor bangun datar tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilBangun()
        {
            Console.Clear();

            int noUrut = 0;
            string jenis;
            Console.WriteLine("Data Bangun Datar");
            foreach (BangunDatar bangun in bangundatar)
            {
                if (bangun is Persegi)
                {
                    jenis = "Persgi";
                }
                else if (bangun is PersegiPanjang)
                {
                    jenis = "Persgi Panjang";
                }
                else if (bangun is TrapesiumSamaKaki)
                {
                    jenis = "Trapesium Sama Kaki";
                }
                else if (bangun is SegitigaSamaSisi)
                {
                    jenis = "Segitiga Sama Sisi";
                }
                else if (bangun is BelahKetupat)
                {
                    jenis = "Belah Ketupat";
                }
                else if (bangun is LayangLayang)
                {
                    jenis = "Layang - Layang";
                }
                else if (bangun is Lingkaran)
                {
                    jenis = "Lingkaran";
                }
                else
                {
                    jenis = "Tidak ada";
                }
                noUrut++;
                Console.WriteLine("{0}. Nomor BangunDatar : {1}, Nama Bangun Datar: {2}, Luas Bangun Datar: {3}, Keliling Bangun Datar: {4}", noUrut, bangun.noBangun, jenis, bangun.Luas(), bangun.Keliling());
            }
            if (noUrut < 1)
            {
                Console.WriteLine("Data Bangun datar Kosong");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }

        static void JumlahBangun()
        {
            Console.Clear();

            bool loop = true;
            double i = 0, total = 0;
            while(loop)
            {
                Console.WriteLine("Menjumlahkan Luas Bangun");
                Console.Write("Nomor Bangun : ");
                string kode = Console.ReadLine();
                foreach (BangunDatar bangun in bangundatar)
                {
                    if (bangun.noBangun == kode)
                    {
                        i = bangun.Luas();
                    }
                    else
                    {
                        Console.WriteLine("\nKode produk tidak ditemukan");
                    }
                }
                total += i;
                Console.Write("Jumlah luas semua bangun : {0}", total);
                Console.Write("Tambahkan bangun ruang lagi? (y/n)");
                string lagi = Console.ReadLine();
                if(lagi == "y" || lagi == "Y")
                {
                    loop = true;
                }
                else
                {
                    loop = false;
                }
            }

            Console.ReadKey();
        }
    }
}
