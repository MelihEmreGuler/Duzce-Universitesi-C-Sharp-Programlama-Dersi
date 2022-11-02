using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1 //projeye özgü bir isim
    //bu namespacein birden çok classı olacak ama
    //Program classı bu namespacenin başlangıç classı Main de başlangıç fonksiyonu
{
    
    internal class Program //projenin class'ı 
//bu class tan bir nesne üretmeden main fonksiyonunun kullanmak için main fonksiyonu static
    {
        static void Main(string[] args)
        {
            Console.WriteLine("merhaba arkadaşlar");//c w tab tab

            byte veritipi1; //işaretsiz 0 - 255  (8 bit)
            veritipi1 = new byte();

            sbyte veritipi2; //işaretli -128 - +126 (8 bit)
            veritipi2 = new sbyte();

            int veritipi3 = 5 / 2; //işaretsiz

            float veritipi4 = 5f / 2;

            Console.WriteLine(veritipi1);
            Console.WriteLine(veritipi4);

            int veritipi5 = 130;
            //checked //type cast yaptığımızda taşma varmı diye kontrol ediyoruz
            //{
            //  sbyte veritipi6 = (sbyte)veritipi5;
            //  Console.WriteLine(veritipi6);
            //}

            //Hocanın notundan convert'leri incele
            //string formatlamaya bak {1} {2} {0}

            Console.WriteLine(veritipi5.GetType()); //getType() örneklerini incele

            //as örneklerini incele dönüştürebiliyorsan stringe dönüştür
            //is operatörü dönüşümün durumunu bool olarak verir
            // ternary (tek satırda if koşulu kullanımı) örneğini 
            #region abc (region ismi)

            Type type = typeof(Program);
            Console.WriteLine(type);
            //nesnelerin tipini getType ile nesne oluşturmadığım şeylerin tipini typeof ile alıyoruz
            Program program = new Program();
            Console.WriteLine(program.GetType());
            #endregion

            //switch case yapısında default un break' i olmak zorunda 

            Console.ReadLine(); //konsolun kapanmaması için kullanılıyor
            }
        }
    }
