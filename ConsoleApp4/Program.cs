using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//------------------------------------



namespace ConsoleApp4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //20 boyutlu bir int dizi tanımlicaz
            //random sınıfından bu diziyi dolduracağuz
            //bu dizinin elemanlarını ekrana yazdıracagiz
            //bu diziyi kucukten buyuge siralicaz 
            //bu dizinin sirali halini yazdir
            int[] array1 = new int[20];

            Random r = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = r.Next(0,100); //0 - 99 arasinda
            }
            arrayEkranaYazdir(array1);


            Console.WriteLine();
            Console.WriteLine("-------------------");

            //siralama 

            array1 = DiziSirala(array1);

            arrayEkranaYazdir(array1);

            //----------------------------------------------------------
            //dizinin uzunlugunun yarisina bakar 

            //ilk indis son indisten kucuk oldugu surece don (ilk indis <= son indis)
            

            int[] array2 = new int[8]
            {
                5,10,20,25,26,77,88,99
            };
            Console.WriteLine("arayacaginiz sayiyi giriniz: ");
            int aranan = Convert.ToInt32(Console.ReadLine());

            int indis = ikiliArama(aranan, array1);

            if(indis == -1)
            {
                Console.WriteLine("aranan sayi bulunamadi");
            }
            else
            {
                Console.WriteLine("aranan sayi bulundu indisi: " + indis);
            }

            Console.ReadLine();

        }

        public static int ikiliArama(int aranan, int[] array)
        {
            //8 15 24 25 29* 31 33 37 38 43 52 54 56 60 64 67 69 74 91 94
            int ilkIndis = 0;
            int sonIndis = array.Length - 1;
            

            while(ilkIndis <= sonIndis)
            {
                int ortaIndis = (ilkIndis + sonIndis) / 2;
                if(aranan < array[ortaIndis])
                {
                    sonIndis = ortaIndis - 1;
                }else if(aranan > array[ortaIndis])
                {
                    ilkIndis = ortaIndis + 1;
                }
                else //irta indisteki eleman aranana esitse orta indsi dön (yani buldun demek)
                {
                    return ortaIndis;
                }
                
            }
            

            return -1;
        }

        public static int[] DiziSirala(int[] dizi)
        {
            
            int tmp;
            bool sirali;
            for (int i = 1; i < dizi.Length; i++)
            {
                sirali = true;
                for (int j = 0; j < dizi.Length - i; j++)
                    if (dizi[j] > dizi[j + 1])
                    {
                        sirali = false;
                        tmp = dizi[j];
                        dizi[j] = dizi[j + 1];
                        dizi[j + 1] = tmp;
                    }
                if (sirali)
                {
                    break;
                }
            }
            return dizi;
        }

        public static void arrayEkranaYazdir(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine();
        }
    }
}
