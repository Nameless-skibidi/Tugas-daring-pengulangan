using System;

namespace Pengulangan
{
    class For
    {
        public static void Contoh1()
        {
            for (int i = 1; i <= 5; i++)
                Console.WriteLine(i);
        }

        public static void Contoh2()
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine(i);
        }

        public static void Contoh3()
        {
            for (int i = 2; i <= 20; i += 2)
                Console.WriteLine(i);
        }

        public static void Contoh4()
        {
            for (int i = 10; i >= 1; i--)
                Console.WriteLine(i);
        }

        public static void Contoh5()
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine("5 x " + i + " = " + (5 * i));
        }
    }

    class While
    {
        public static void Contoh1()
        {
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public static void Contoh2()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public static void Contoh3()
        {
            int i = 1;
            while (i <= 15)
            {
                Console.WriteLine(i);
                i += 2;
            }
        }

        public static void Contoh4()
        {
            int i = 1, jumlah = 0;
            while (i <= 5)
            {
                jumlah += i;
                i++;
            }
            Console.WriteLine("Jumlah = " + jumlah);
        }

        public static void Contoh5()
        {
            int i = 5;
            while (i >= 1)
            {
                Console.WriteLine(i);
                i--;
            }
        }
    }

    class DoWhile
    {
        public static void Contoh1()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 5);
        }

        public static void Contoh2()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);
        }

        public static void Contoh3()
        {
            int i = 2;
            do
            {
                Console.WriteLine(i);
                i += 2;
            } while (i <= 20);
        }

        public static void Contoh4()
        {
            int i = 10;
            do
            {
                Console.WriteLine(i);
                i--;
            } while (i >= 1);
        }

        public static void Contoh5()
        {
            int i = 1, jumlah = 0;
            do
            {
                jumlah += i;
                i++;
            } while (i <= 10);

            Console.WriteLine("Jumlah = " + jumlah);
        }
    }

    class Foreach
    {
        public static void Contoh1()
        {
            string[] nama = { "Andi", "Budi", "Citra", "Dani", "Eka" };
            foreach (string siswa in nama)
                Console.WriteLine(siswa);
        }

        public static void Contoh2()
        {
            string[] buah = { "Apel", "Mangga", "Jeruk", "Pisang", "Anggur" };
            foreach (string b in buah)
                Console.WriteLine(b);
        }

        public static void Contoh3()
        {
            int[] angka = { 10, 20, 30, 40, 50 };
            foreach (int a in angka)
                Console.WriteLine(a);
        }

        public static void Contoh4()
        {
            int[] nilai = { 80, 85, 90, 75, 95 };
            int jumlah = 0;
            foreach (int n in nilai)
                jumlah += n;

            Console.WriteLine("Jumlah nilai = " + jumlah);
        }

        public static void Contoh5()
        {
            string[] pelajaran =
            {
                "Matematika", "Bahasa Indonesia",
                "Bahasa Inggris", "Informatika", "IPA"
            };

            foreach (string p in pelajaran)
                Console.WriteLine(p);
        }
    }

    class Array
    {
        public static void Contoh1()
        {
            string[] nama = { "Andi", "Budi", "Citra", "Dani", "Eka" };
            for (int i = 0; i < nama.Length; i++)
                Console.WriteLine(nama[i]);
        }

        public static void Contoh2()
        {
            int[] angka = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < angka.Length; i++)
                Console.WriteLine(angka[i]);
        }

        public static void Contoh3()
        {
            int[] angka = { 10, 20, 30, 40, 50 };
            int jumlah = 0;
            for (int i = 0; i < angka.Length; i++)
                jumlah += angka[i];

            Console.WriteLine("Jumlah = " + jumlah);
        }

        public static void Contoh4()
        {
            int[] nilai = { 70, 85, 90, 65, 80 };
            int terbesar = nilai[0];

            for (int i = 1; i < nilai.Length; i++)
                if (nilai[i] > terbesar)
                    terbesar = nilai[i];

            Console.WriteLine("Nilai terbesar = " + terbesar);
        }

        public static void Contoh5()
        {
            int[] angka = { 1, 2, 3, 4, 5 };
            for (int i = angka.Length - 1; i >= 0; i--)
                Console.WriteLine(angka[i]);
        }
    }

    class List
    {
        public static void Contoh1()
        {
            System.Collections.Generic.List<string> siswa =
                new System.Collections.Generic.List<string>
                { "Andi", "Budi", "Citra", "Dani", "Eka" };

            foreach (string nama in siswa)
                Console.WriteLine(nama);
        }

        public static void Contoh2()
        {
            System.Collections.Generic.List<string> buah =
                new System.Collections.Generic.List<string>
                { "Apel", "Mangga", "Jeruk", "Pisang" };

            foreach (string b in buah)
                Console.WriteLine(b);
        }

        public static void Contoh3()
        {
            System.Collections.Generic.List<string> nama =
                new System.Collections.Generic.List<string>
                { "Andi", "Budi", "Citra" };

            nama.Remove("Budi");

            foreach (string n in nama)
                Console.WriteLine(n);
        }

        public static void Contoh4()
        {
            System.Collections.Generic.List<int> angka =
                new System.Collections.Generic.List<int>
                { 10, 20, 30, 40, 50 };

            int jumlah = 0;
            foreach (int a in angka)
                jumlah += a;

            Console.WriteLine("Jumlah = " + jumlah);
        }

        public static void Contoh5()
        {
            System.Collections.Generic.List<string> siswa =
                new System.Collections.Generic.List<string>
                { "Andi", "Budi", "Citra", "Dani", "Eka" };

            string cari = "Citra";

            if (siswa.Contains(cari))
                Console.WriteLine(cari + " ditemukan");
            else
                Console.WriteLine(cari + " tidak ditemukan");
        }
    }

    class Menu
    {
        public static void Jalankan()
        {
            while (true)
            {
                Console.WriteLine("\n=== MENU PENGULANGAN ===");
                Console.WriteLine("1. For");
                Console.WriteLine("2. While");
                Console.WriteLine("3. Do While");
                Console.WriteLine("4. Foreach");
                Console.WriteLine("5. Array");
                Console.WriteLine("6. List");
                Console.WriteLine("0. Keluar");
                Console.Write("Pilih jenis program: ");

                string pilihan = Console.ReadLine();
                if (pilihan == "0")
                    break;

                Console.WriteLine();

                switch (pilihan)
                {
                    case "1":
                        Console.WriteLine("=== FOR ===");
                        Console.WriteLine("\nContoh 1: Angka 1-5");
                        For.Contoh1();
                        Console.WriteLine("\nContoh 2: Angka 1-10");
                        For.Contoh2();
                        Console.WriteLine("\nContoh 3: Angka genap");
                        For.Contoh3();
                        Console.WriteLine("\nContoh 4: Hitung mundur");
                        For.Contoh4();
                        Console.WriteLine("\nContoh 5: Perkalian 5");
                        For.Contoh5();
                        break;

                    case "2":
                        Console.WriteLine("=== WHILE ===");
                        Console.WriteLine("\nContoh 1: Angka 1-5");
                        While.Contoh1();
                        Console.WriteLine("\nContoh 2: Angka 1-10");
                        While.Contoh2();
                        Console.WriteLine("\nContoh 3: Angka ganjil");
                        While.Contoh3();
                        Console.WriteLine("\nContoh 4: Jumlah angka 1-5");
                        While.Contoh4();
                        Console.WriteLine("\nContoh 5: Hitung mundur");
                        While.Contoh5();
                        break;

                    case "3":
                        Console.WriteLine("=== DO WHILE ===");
                        Console.WriteLine("\nContoh 1: Angka 1-5");
                        DoWhile.Contoh1();
                        Console.WriteLine("\nContoh 2: Angka 1-10");
                        DoWhile.Contoh2();
                        Console.WriteLine("\nContoh 3: Angka genap");
                        DoWhile.Contoh3();
                        Console.WriteLine("\nContoh 4: Hitung mundur");
                        DoWhile.Contoh4();
                        Console.WriteLine("\nContoh 5: Jumlah angka 1-10");
                        DoWhile.Contoh5();
                        break;

                    case "4":
                        Console.WriteLine("=== FOREACH ===");
                        Console.WriteLine("\nContoh 1: Nama siswa");
                        Foreach.Contoh1();
                        Console.WriteLine("\nContoh 2: Daftar buah");
                        Foreach.Contoh2();
                        Console.WriteLine("\nContoh 3: Daftar angka");
                        Foreach.Contoh3();
                        Console.WriteLine("\nContoh 4: Jumlah nilai");
                        Foreach.Contoh4();
                        Console.WriteLine("\nContoh 5: Mata pelajaran");
                        Foreach.Contoh5();
                        break;

                    case "5":
                        Console.WriteLine("=== ARRAY ===");
                        Console.WriteLine("\nContoh 1: Nama siswa");
                        Array.Contoh1();
                        Console.WriteLine("\nContoh 2: Daftar angka");
                        Array.Contoh2();
                        Console.WriteLine("\nContoh 3: Jumlah angka");
                        Array.Contoh3();
                        Console.WriteLine("\nContoh 4: Nilai terbesar");
                        Array.Contoh4();
                        Console.WriteLine("\nContoh 5: Array terbalik");
                        Array.Contoh5();
                        break;

                    case "6":
                        Console.WriteLine("=== LIST ===");
                        Console.WriteLine("\nContoh 1: Daftar siswa");
                        List.Contoh1();
                        Console.WriteLine("\nContoh 2: Daftar buah");
                        List.Contoh2();
                        Console.WriteLine("\nContoh 3: Menghapus nama");
                        List.Contoh3();
                        Console.WriteLine("\nContoh 4: Jumlah angka");
                        List.Contoh4();
                        Console.WriteLine("\nContoh 5: Mencari nama");
                        List.Contoh5();
                        break;

                    default:
                        Console.WriteLine("Pilihan tidak tersedia!");
                        break;
                }

                Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
                Console.ReadLine();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Menu.Jalankan();
        }
    }
}
