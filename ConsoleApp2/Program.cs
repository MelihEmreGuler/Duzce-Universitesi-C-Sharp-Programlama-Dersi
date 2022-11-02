using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            
            for (int i = 0; i < 100; i++)
            {
                if (i % 7 == 0 && (i != 0))
                {
                    continue;
                }
                   
                Console.Write(i+ "-");
            }

            Console.WriteLine("------------------------");


            for (int i = 100; i > 0; i--)
            {
                if (i % 13 == 0)
                    break;
                Console.Write(i+ "-");
            }

            Console.WriteLine("------------------------");

            int x = 99;
            do
            {
                x--;
                if (x% 7 == 0)
                {
                    continue;
                }
                Console.Write(x + " - ");

            } while (x > 0);

            Console.WriteLine("------------------------");

            int y = 99;
            while (y>0)
            {
                
                if(y% 7 == 0)
                {
                    y--;
                    continue;
                }
                Console.Write(y-- + " - ");

            }

            int[] dizi;
            dizi = new int[10];

            int[] dizi1 = new int[10];

            int[] dizi2 = { 1, 2, 3, 4 };
            //hocanın kodundaki dizileride referans tip eşitlemesiyle bellekte aynı adresin tutulmasını incele


            //string özel bir referans tip olduğu için başka stringlerle eşitlendiğinde referans tip gibi değeri değişmez

            String s1 = "Merhaba";
            Console.WriteLine(s1.GetType());//get type bir metod dur.
            Console.WriteLine(s1.Length); //length bir property dir.

            Console.WriteLine("------------------------");

            foreach(var item in dizi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("asd");

            Object object1;
            object1 = new Object();
            object1 = "asd";

            //obje runtime sırasında tipi belirlenen bir değişkendir.

            Object[] objects1 = { object1, object1 };

            //düzenli dizi = her satırında eşit sayıda eleman vardır


            int [] objects2 = { 1, 2, 3, 4 };

            //GetUpperBound maksimum kaç indise kadar gidebileceğimiz sayıyı söyler.

            Console.WriteLine("------------------------");

            //random sınıfı incele

            Console.WriteLine(objects2.GetUpperBound(0));


            Console.WriteLine("------------------------");

            int[,] dizi3 = new int[3, 2]; //3 satır 2 sütun


            Random r = new Random();

            for(int i = 0; i < dizi3.GetLength(0); i++)
            {
                for(int j = 0; j < dizi3.GetLength(1); j++)
                {
                    dizi3[i, j] = r.Next(1, 100);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(dizi3[i, j]+ " ");
                    
                }
                Console.WriteLine();
            }

            int[] dizi4 = new int[3];

            for(int i = 0; i< dizi4.Length; i++)
            {
                Console.WriteLine(i + ". eleman: ");
                dizi4[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Kontrol edeceğiniz sayıyı girin:");
            int alınan = new int();
            alınan = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < dizi4.Length; i++)
            {
                if (dizi4[i] == alınan)
                {
                    Console.WriteLine("bildiniz indisi: " + i);
                }
            }

            Console.ReadLine();
        }
    }
}