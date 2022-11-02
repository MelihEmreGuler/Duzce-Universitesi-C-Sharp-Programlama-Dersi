using System;

namespace ConsoleApp3 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static int Linearsearch(int[] dizi, int aranan)
        {
            int n = 0;
            foreach (int item in dizi)
            {
                if (item == aranan)
                {
                    return n;
                }
                n++;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            //// sınav sorusu
            int[] dizi1 = new int[] { 5, 1, 5, 7, 6, 3 };
            int aranan = 3;
            int indis = Linearsearch(dizi1, aranan);
            Console.WriteLine(indis);
            Console.WriteLine("**************************");


            // sınav sorusu 2
            int[] dizi2 = { 45, 78, 7, 99, 22, 11 };
            dizi2 = DiziSirala(dizi2);
            foreach (var item in dizi2)
            {
                Console.WriteLine(item);
            }
        }

        private static int[] DiziSirala(int[] dizi)
        {
            int[] newArray = new int[dizi.Length];
            for (int j = 0; j < dizi.Length; j++)
            {
                int kucuk = dizi[j];
                int indis = 0;
                for (int i = j; i < dizi.Length; i++)
                {
                    if (dizi[i] < kucuk)
                    {
                        kucuk = dizi[i];
                        indis = i;
                    }
                }
                dizi[indis] = dizi[j];
                dizi[j] = kucuk;
                newArray[j] = kucuk;
            }
            return newArray;
        }
    }

}
