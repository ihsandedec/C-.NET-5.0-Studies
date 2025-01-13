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
            
              Console.Write("Benim adim: ");  //  Console.Write alt satıra geçmez 
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
              
            #endregion
        }
    }
}
