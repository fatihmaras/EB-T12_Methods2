using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodlarOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir Sayı Giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            int KareDeger = KareAl(sayi);

            if (KareDeger > 25)
            {
                Console.WriteLine("Karesi 25'ten Büyüktür");
            }
            else
            {
                Console.WriteLine("Karesi 25'ten Küçüktür");

            }
            Console.ReadLine();


        }
        static int KareAl(int a)
        {
            return a * a;

        }

    }
}
