﻿﻿using System;
using System.Linq.Expressions;

namespace ErrorManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Mini Oyun
            //Console.WriteLine("Aklından bir sayı tut ve söyleme sonra enter tuşuna bas");
            //Console.ReadLine();
            //Console.WriteLine("Tuttuğun sayıyı iki ile çarp ve enter tuşuna bas");
            //Console.ReadLine();
            //Console.WriteLine("Bulduğun sonucu belirlediğin ikinci bir sayı ile topla ve bu ikinci sayıyı ekrana yazdıktan sonra enter tuşuna bas");
            //double number = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Bulduğun sonucu ikiye böl");
            //Console.ReadLine();
            //Console.WriteLine("Bulduğun sonuçtan ilk tuttuğun sayıyı çıkar");
            //Console.ReadLine();
            //string tahmin = (number / 2).ToString();
            //Console.WriteLine("Galiba tahmin ediyorum. Bulduğun sayı = " + tahmin + " mi/mu?"); 
            #endregion

            try
            {
                Console.Write("1. Sayiyi giriniz : ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2. Sayiyi giriniz : ");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.Write(number1 * number2);

            }
            catch (FormatException)
            {
                Console.Write("Hatalı giriş. Lütfen sayi giriniz ");
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally 
            { 
                Console.WriteLine("Burası son durak ");
            }




        }
    }
}