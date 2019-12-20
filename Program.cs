using System;

/*Created by Rizky Khapidsyah*/

namespace MethodOverloading__CS
{
    class Program
    {
        static void Main(string[] args)
        {
            int IAi;        //InputAngka (Integer)
            double IAd;     //InputAngka (Double)

            String IS;  //InputString

            String[] S = new string[15];

            S[0] = "-";
            S[1] = "Contoh 1: Method Overloading";
            S[2] = "Contoh 2: Method Untuk Rekursif";
            S[3] = "Masukkan Nilai Ditampilkan Integer (Cth: 13)   : ";
            S[4] = "Masukkan Nilai Ditampilkan Double (Cth: 13.2)  : ";
            S[5] = "Masukkan Nilai Untuk Difaktorialkan : ";
            S[6] = "Nilai Faktorial dari ";
            S[7] = " adalah ";
            S[8] = "Contoh 3: Mencetak Pola Gambar Segitiga Sembarang";
            S[9] = "Isi Jumlah Angka Pola (Mis: 6) = ";

            CetakBanner(S[0], S[1], S[0]);
            Console.Write(S[3]); IAi = Convert.ToInt32(IS = Console.ReadLine());
            Console.Write(S[4]); IAd = Convert.ToDouble(IS = Console.ReadLine()); BarisBaru();

            Cetak(IAi);
            Cetak(IAd);
            Cetak(IS + "\n");

            CetakBanner(S[0], S[2], S[0]);
            Console.Write(S[5]); IAi = Convert.ToInt32(IS = Console.ReadLine()); BarisBaru();
            Console.WriteLine(S[6] + "{0}!" + S[7] + "{1}", IAi, Faktorial(IAi)); BarisBaru();

            CetakBanner(S[0], S[8], S[0]);
            Console.Write(S[9]); IAi = Convert.ToInt32(IS = Console.ReadLine()); BarisBaru();
            Pola(IAi);


            Console.ReadLine();
        }

        //Fungsi Utama: Cetak
        static void Cetak(int A)
        {
            Console.WriteLine("Nilai (integer) - Bilangan Bulat : {0}", A);
        }

        //Overloading Fungsi: Cetak Untuk Tipe Data Double
        static void Cetak(double A)
        {
            Console.WriteLine("Nilai (double)  - Bilangan Cacah : {0}", A);
        }

        //Overloading Fungsi: Cetak Untuk Tipe Data String
        static void Cetak(string A)
        {
            Console.WriteLine("Nilai (string)  - Dalam Text     : {0}", A);
        }

        static int Faktorial(int N)
        {
            if (N == 1)
            {
                return 1;
            }

            return N * Faktorial(N - 1);
        }

        static void Pola(int G)
        {
            for (int i = 1; i <= G; i++) 
            {
                for (int j = i; j <= G; j++) 
                {
                    Console.Write(" ");
                }

                    for (int k = 1; k <= 2 * i - 1; k++)
                    {
                        Console.Write("*" + " ");
                    }

                BarisBaru();
            }
        }


        static void CetakBanner(string GarisAtas, string Judul, string GarisBawah)
        {
            for (int i = 0; i <= 50; i++)
            {
                Console.Write(GarisAtas);
 
            }

            BarisBaru(); Console.Write(Judul); BarisBaru();

                for (int i = 0; i <= 50; i++)
                {
                    Console.Write(GarisBawah);

                }

            BarisBaru();
        }

        static void BarisBaru()
        {
            Console.WriteLine();
        }
    }
}
