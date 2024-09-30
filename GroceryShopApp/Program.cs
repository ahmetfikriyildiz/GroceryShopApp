using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryShopApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rüya Manavına Hoşgeldiniz ! ");
            int x = 2, y = 3, z = 4;
            Console.WriteLine($"Elma  = {x} TL");
            Console.WriteLine($"Armut  = {y} TL");
            Console.WriteLine($"Çilek  = {x} TL");
            Console.WriteLine($"Muz  = {y} TL");
            Console.WriteLine($"Diger bütün meyveler  = {z} TL");

            Console.Write("Hangi meyveyi satin almak istersiniz? ");
            Console.Write("(Elma/Armut/Çilek/Muz/Diger) : ");
            string secim = Console.ReadLine().ToLower();

            //if (secim == "elma")
            //{
            //    Console.WriteLine("Sectiginiz Meyvenin Fiyatı : 2 TL");
            //}
            //else if (secim == "armut")
            //{
            //    Console.WriteLine("Sectiginiz Meyvenin Fiyatı : 3 TL");
            //}
            //else if (secim == "çilek")
            //{
            //    Console.WriteLine("Sectiginiz Meyvenin Fiyatı : 2 TL");
            //}
            //else if (secim == "muz")
            //{
            //    Console.WriteLine("Sectiginiz Meyvenin Fiyatı : 3 TL");
            //}
            //else
            //{
            //    Console.WriteLine("Sectiginiz Meyvenin Fiyatı : 4 TL");
            //}

            switch (secim)
            {
                case "elma":
                    Console.WriteLine("Sectiginiz Meyvenin Fiyatı: 2 TL");
                    break;
                case "armut":
                    Console.WriteLine("Sectiginiz Meyvenin Fiyatı: 3 TL");
                    break;
                case "çilek":
                    Console.WriteLine("Sectiginiz Meyvenin Fiyatı: 2 TL");
                    break;
                case "muz":
                    Console.WriteLine("Sectiginiz Meyvenin Fiyatı: 3 TL");
                    break;
                default:
                    Console.WriteLine("Sectiginiz Meyvenin Fiyatı: 4 TL");
                    break;
            }

            Console.ReadLine();
        }
    }
}
