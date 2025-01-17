﻿﻿using System;
using System.Xml.Linq;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Giris
            /*Console.WriteLine("Hello World!");
            
                Console.WriteLine("Merhaba Dünya");
                Her Satır ; ile biter
             */

            #endregion

            #region Console.Write,WriteLine,Read,ReadKey
            /*
              Console.Write("Benim adim: ");  //  Console.Write alt satıra geçmez 
               Console.WriteLine("ismail");    //  Console.WriteLine alt  satıra geçer.
               Console.Write("Soyadim: ");
               Console.WriteLine("dedeç");
               Console.Read();                 // Enter tusuna basmadan diger kodlara gecmez bekler.
               Console.Write("deneme, ");
               Console.Write("deneme01, ");
               Console.Write("deneme02, ");

               Console.WriteLine();
               Console.ReadKey();                 // Klavyeden herhangi bir tusa tusuna basmadan diger kodlara gecmez bekler.
               Console.WriteLine("deneme, ");
               Console.WriteLine("deneme01, ");
               Console.WriteLine("deneme02, ");
              */
            #endregion

            #region Uygulama
            // Console.ReadLine();
            /* isminiz ne? diye sorulacak. aynı satıra adı yazılacak.
            bir alt satıra geçilecek. Soyadınız ne? diye sorulacak. ve aynı satıra yazılacak. bir alt satıra inilerek ekranda iyi günler yazılacak.
            

            Console.Write("İsminiz Ney?");
            Console.ReadLine();
            Console.Write("Soyadınız Ney?");
            Console.ReadLine();
            Console.Write("İyi Günler");
            */
            #endregion

            #region StringDegiskenTipi
            //  Degisken = Veri  -> atama operatörü sagdakiyi veriyi soldaki degiskene atar
            /*
             string name;            
             name = "asaf";
             Console.WriteLine(name); 
             */
            #endregion


            #region  ReadLine komutu ile kullanicidan input alma
            /*
            string name = Console.ReadLine();
            Console.Write(name);
            */

            /*
                UYGULAMA
                kullanıcıdan isim alinacak.
                kullanici soyismi alinacak .
                ekrana hoşgeldin ismi soyismi yazilacak.

           

            string name, last_name;
            Console.Write("isminizi giriniz: ");
            name = Console.ReadLine();
            Console.Write("Soyisminizi giriniz: ");
            last_name = Console.ReadLine();
            Console.WriteLine("Hoşgeldin " + name + " " + last_name);

             */
            #endregion

            #region Uygulama02
            /*
            // "En sevdiğin meyve hangisi?" sorusunu sor
            Console.WriteLine("En sevdiğin meyve hangisi?");
            string fruit = Console.ReadLine();  // Kullanıcıdan meyve cevabını al

            // "En sevdiğin tatlı hangisi?" sorusunu sor
            Console.WriteLine("En sevdiğin tatlı hangisi?");
            string dessert = Console.ReadLine();  // Kullanıcıdan tatlı cevabını al

            // Cevapları ekrana yazdır
            Console.WriteLine("\nDur tahmin ediyorum. En sevdiğin tatlı: " + dessert);
            Console.WriteLine("En sevdiğin meyve: " + fruit);

            // Uygulama sonlanmadan önce enter tuşuna basılmasını bekle
            Console.WriteLine("\nUygulama sonlanması için Enter'a bas.");
            Console.ReadLine(); 
            */
            #endregion

            #region Degisken Tipleri
            /*
                Değişken Tipleri

                -Metinsel -
                    * string = ""
                    * char = ''
                -Sayısal -
                    -Tam sayılar -
                        * byte = 255
                        * short = 32767 
                        * int = 2.1 milyar
                    - Ondalıklı Sayılar -
                        * float = 11.4F
                        * double = 13.7
                        * decimal = 15.8M
               - mantıksal -          
                * bool = true veya false
                 */

            //char first = 'a';
            //byte test = 254;
            //short test2 = 123;
            //int number = 444;
            //float test3 = 11.4F;
            //double test4 = 11.4;
            //decimal des = 15.8M;
            //bool test5 = false; 
            #endregion

            #region Aritmatik Operatörler
            // Aritmatik Operatörler
            // + - * / %

            //int number = 4 + 8;
            //Console.WriteLine(number);

            // kısa kenar 10  uzun kenarı 17 cm olam dikdiörtgen alanı nedir ?

            /*
            double shortEdge = 10;
            double longtEdge = 17;
            double area = shortEdge * longtEdge;
            Console.WriteLine(area);

            string name = "asaf";
            string surname = "dedec";
            string fullName = name + " " + surname;
            Console.WriteLine(fullName);

            int number = 5;
            //number = 5 * 5;
            //number *= 5;
            //number += 5;
            Console.WriteLine(number);
            */
            #endregion

            #region Mantiksal Operatörler
            // Mantıksal Operatörler
            // == , <> , <= , >=

            //Console.Write("5 ile 7 eşitmi?");
            //Console.WriteLine(5 == 7);
            //Console.Write("4 büyükmü 8 den?");
            //Console.WriteLine(4 > 8); 
            //Console.Write("9 <= 9"); 
            //Console.WriteLine(9 <= 9);

            // soru: metinsel bir sayı tanımlayalım. consol ekranında bunu bilmeye çalışalım. bilirsek true bilemezsek false yazalım

            //Console.Write("Bir sayi tahmin ediniz : ");
            //string secretNumber = "18";
            //string number = Console.ReadLine();
            //Console.Write("Tahmin sonucu : ");
            //Console.WriteLine(secretNumber == number);
            #endregion


            #region Arttırma ve Azaltma Kullanimi
            int number = 5;
            number = number + 1;
            Console.WriteLine(number);

            int number02 = 10;
            number02 += 1;
            Console.WriteLine(number02);

            int number03 = 20;
            Console.WriteLine(number03 + 1);
            Console.WriteLine(number03);

            Console.WriteLine("******************************");

            Console.WriteLine(++number03);      //degiskenimizin içine yazar
            Console.WriteLine(number03);

            Console.WriteLine("******************************");

            Console.WriteLine(number03);
            Console.WriteLine(number03++);
            Console.WriteLine(number03);

            Console.WriteLine("******************************");
            int number04 = 5;
            Console.WriteLine(1 + number04);    //sadece veriye 1 ekledik 
            Console.WriteLine(++number04);      //degiskene de 1 ekledik 
            Console.WriteLine(number04--);     // degisken 5 oldu 
            Console.WriteLine(number04); 
            #endregion

        }
    }
}