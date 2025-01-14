using System;

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
            
             /* Console.Write("Benim adim: ");  //  Console.Write alt satıra geçmez 
               Console.WriteLine("ihsan");    //  Console.WriteLine alt  satıra geçer.
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
            */
            Console.Write("İsminiz Ney?");
            Console.ReadLine();
            Console.Write("Soyadınız Ney?");
            Console.ReadLine();
            Console.Write("İyi Günler"); 
            #endregion

            #region StringDegiskenTipi
             //  Degisken = Veri  -> atama operatörü sagdakiyi veriyi soldaki degiskene atar
            string name;
            name = "asaf";
            Console.WriteLine(name); 
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
            */
            string name, last_name;
            Console.Write("isminizi giriniz: ");
            name = Console.ReadLine();
            Console.Write("Soyisminizi giriniz: ");
            last_name = Console.ReadLine();
            Console.WriteLine("Hoşgeldin " + name + " " + last_name);
            #endregion
        }
    }
}
