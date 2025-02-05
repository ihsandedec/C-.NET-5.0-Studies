using System;

namespace DecisionMechanisms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if-else Ornegi
            /*

               Soru 1) Kızınca tüküren hayvan hangisidir.
               a) lama
               b) deve
               Soru 2) Dünyaya en yakın olan gezegen hangisidir.
               a) venüs
               b) mars
               Soru 3) 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır
               a) 7
               b) 12
               */

            int control = 0;
            Console.WriteLine("SORU 1) Kızınca tukuren hayvan nedir ?");
            Console.WriteLine("a) lama");
            Console.WriteLine("b) deve");

            string result = Console.ReadLine();
            if (result == "a")
            {
                control += 1;
            }

            Console.WriteLine("SORU 2) Dünyaya en yakın olan gezegen hangisidir ?");
            Console.WriteLine("a) venüs");
            Console.WriteLine("b) mars");
            result = Console.ReadLine();
            if (result == "a")
            {
                control += 1;
            }

            Console.WriteLine("SORU 3) 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?");
            Console.WriteLine("a) 7");
            Console.WriteLine("b) 12");
            result = Console.ReadLine();
            if (result == "b")
            {
                control += 1;
            }

            if (control >= 2)
            {
                Console.WriteLine("Testi Başarıyla Gectiniz");
            }
            else
            {
                Console.WriteLine("Daha Cok Calısman Gerek !");

            } 
            #endregion




        }
    }
}
