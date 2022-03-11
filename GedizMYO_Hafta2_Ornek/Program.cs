using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GedizMYO_Hafta2_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ürün Fiyatını Giriniz : ");
            double fiyat = double.Parse(Console.ReadLine());
            Console.WriteLine("İndirim Oranı Giriniz : ");
            float oran = float.Parse(Console.ReadLine());
            /*  double indirimTutari = (fiyat * oran);
              double indirimliFiyat = fiyat - indirimTutari;*/
            double indirimliFiyat = fiyat - (fiyat * oran);
            Console.WriteLine($"İndirim Tutarı : {(fiyat * oran):N2}");
            Console.WriteLine($"İndirimli Fiyat : {indirimliFiyat:N2}");
        }
    }
}
