using System;


namespace GedizMYO_NYP_II_Hafta_1
{
 
 
   
   
    class gediz_nyp_2
    {
        static void hesapla()
        {
            int x = 5 + 6;
            deneme d = new deneme();
           // d.yaz();

        }

        static void Main(string[] args)
        { //program çalıştırıldığında ilk başlaycak olan metod/satır dır.
            Console.WriteLine("Merhaba GEDİZ MYO NYP II Dersi");
            Console.WriteLine();
          //  Console.Write("Kütahya Dumlupınar Üniversitesi");
            string str = "Kütahya Dumlupınar Üniversitesi\nGediz Meslek Yüksekokulu";

            Console.Write(str);
            Console.WriteLine("--------------------------");

            Console.WriteLine((45+5)/2);

            Console.WriteLine("Yapılan işlem sonucu : " + 100+6);
            Console.WriteLine("Yapılan işlem sonucu : " + (100+6));
            Console.WriteLine("45+9="+(45+9));
            string ad = "Amet Can";
            double maas = 4500;
            Console.WriteLine(ad+"'ın maaşı : "+maas);
            Console.WriteLine("{0}'ın Maaşı : {1} ",ad,maas);
            Console.WriteLine($"{ad}'ın Maaşı : {maas}");

            //Console.ReadLine(); //klavyeden enter tuşuna basılana kadar bekler. Aynı zamanda klavyeden girilen verileri okumak ve bir değişkene aktarmak için kullanılır. String tipinde değer döndürür.
            Console.WriteLine("Ad Soyad Giriniz:");
            string adsoyad = Console.ReadLine();

            Console.WriteLine("Ücreti Giriniz");
            string ucret = Console.ReadLine();
            Console.WriteLine($"{adsoyad}'ın Maaşı : {ucret}");

        }

        public class deneme
        {
            public  void yaz()
            {
                string x = "Merhaba. Ben deneme metodundayım ve main bloğundan sonrayım.";
                Console.WriteLine("x değeri : "+x);
            }
        }
        // hataları denetlemek için CTRL + SHIFT + B tuşlarını kullanın...
    }
}
