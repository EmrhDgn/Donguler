using System;


namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string meyve1 = "elma";
            string meyve2 = "armut";
            string meyve3 = "uzum";
            //array dizi
            string[] meyveler = new string[] { "elma", "armut", "uzum", "mandalina", "kiraz" };


            for (int i = 0; i < meyveler.Length; i++)
            {
                Console.WriteLine(meyveler[i]);
            }
            foreach (var meyve in meyveler)
            {
                Console.WriteLine(meyve);
            }
        }
    }
}