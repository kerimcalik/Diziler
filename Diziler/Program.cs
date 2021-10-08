using System;

namespace Diziler
{
    class Program
    {
        static void HataYakalama()
        {
            decimal tcNo;

            Console.Write("TC No yazınız: ");

            try
            {
                tcNo = Convert.ToDecimal(Console.ReadLine());

            }
            catch (Exception hata)
            {
                Console.WriteLine("Tc numaranız hatalı lütfen tekrar yazınız.");
            }
            finally
            {
                tcNo = 12345678901;
            }

            Console.WriteLine("Hata sonrası devam eden kod satırı");

        }

        static void Main(string[] args)
        {
            // dizi tanımlama ifadeleri
            int[] degisken1 = new int[3] { 1, 2, 3 };
            Console.WriteLine(degisken1[0]);

            int[] degisken2 = new int[4];
            int[] degisken3 = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(degisken3[4]);

            degisken2[0] = 1;
            degisken2[1] = 2;
            degisken2[2] = 3;
            degisken2[3] = 4;

            string[] haftaninGunleri = new string[] { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

            for (int i = 0; i < haftaninGunleri.Length; i++)
            {
                Console.WriteLine(haftaninGunleri[i]);
            }

            foreach (var gun in haftaninGunleri)
            {
                Console.WriteLine(gun);
            }

            int x = 0;
            while (x < haftaninGunleri.Length)
            {

                Console.WriteLine(haftaninGunleri[x]);
                x++;
            }

            int[,] degisken5 = new int[2, 3];
            int[,] degisken6 = new int[2, 1] { { 1 }, { 2 } };

            Console.WriteLine(degisken6[1, 0]);


            string[,] degisken7 = new string[2, 2] { { "Ocak", "Şubat" }, { "Pazartesi", "Salı" } };

            int[,] degisken8 = { { 1, 2, 7 }, { 3, 4, 8 }, { 5, 6, 9 } };

            Console.WriteLine(degisken8[1, 2]);

            int[,,] degisken9 = new int[2, 2, 3]
{ { { 1, 2, 3 }, { 4, 5, 6 } },{ { 7, 8, 9 }, { 10, 11, 12 } } };

            // 9
            Console.WriteLine(degisken9[1, 0, 2]);


            var allLength = degisken9.Length;
            var total = 1;
            for (int i = 0; i < degisken9.Rank; i++)
            {
                total *= degisken9.GetLength(i);
            }

            Console.WriteLine("{0} alt kümes toplamı {1}", allLength, total);

            int[][] duzensizDizi = new int[3][];

            duzensizDizi[0] = new int[5];
            duzensizDizi[1] = new int[4];
            duzensizDizi[2] = new int[2];

            duzensizDizi[1][3] = 10;
            //Console.WriteLine(duzensizDizi[1][4]);

            //string[][] aylar = new string[12][];
            //int[] ayGun = { 31, 28, 31, 30, 31 };
            //for (int i = 0; i < aylar.Rank; i++)
            //{
            //    for (int j = 0; j < ayGun.Length; j++)
            //    {
            //        aylar[i][j]
            //    }
            //}

            //aylar[0] = new string[30];
            //aylar[1] = new string[28];
            //aylar[2] = new string[30];
            //aylar[3] = new string[29];

            //aylar[0][0] = "1";
            //aylar[0][1] = "2";
            //aylar[0][2] = "3";

            // küçükten büyüğe sıralar
            Array.Sort(degisken1);
            foreach (var item in degisken1)
            {
                Console.Write(item + ",");
            }
            //büyükten küçüğe sıralar
            Array.Reverse(degisken1);
            foreach (var item in degisken1)
            {
                Console.Write(item + ",");
            }

            //Array dizi1;
            //dizi1.CopyTo(degisken1, 0);
            //degisken1.CopyTo()


            HataYakalama();

            Console.Read();

        }
    }
}
