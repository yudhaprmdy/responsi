﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCustomer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek customer
        static List<Customer> daftarCustomer = new List<Customer>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();
                Console.WriteLine("\t\t ===Pilih Menu Aplikasi===\n\n ");
                Console.WriteLine("Menu :\n\n1. Tambah Customer\n2. Hapus Customer\n3. Tampilkan Customer\n4. Keluar");
                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
        }

        static void TambahCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...


            Customer ctm = new Customer();

            Console.Write("Kode Customer : ");
            ctm.Code = Console.ReadLine();
            Console.Write("Nama Customer: ");
            ctm.Nama = Console.ReadLine();
            Console.Write("Total Piutang : ");
            ctm.Piutang = Console.ReadLine();

            daftarCustomer.Add(ctm);



            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...

            Console.Write("Masukkan Kode: ");
            string search = Console.ReadLine();

            int index = 0;
            foreach (Customer ctm in daftarCustomer)
            {
                if (ctm.Code == search)
                {
                    break;
                }

                index++;
            }
            daftarCustomer.RemoveAt(index);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...

            Console.WriteLine("No\t\tcode\t\tNama\t\tJumlah Piutang");

            int index = 0;
            foreach (Customer ctm in daftarCustomer)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3} ", index + 1, ctm.Code, ctm.Nama, ctm.Piutang);
                index++;
            }
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}

