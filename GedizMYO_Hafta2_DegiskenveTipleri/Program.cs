using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GedizMYO_Hafta2_DegiskenveTipleri
{
    class Program
    {
        //Programı çalıştırmak için CTRL + F5 tuşu
        //debug modda çalıştırmak için F5 tuşu
        static void Main(string[] args)
        {
            string str1;
            str1 = "Merhaba Gediz...";
          //  Console.WriteLine(str1);
            //değer atanmayan değişkenler kullanılamaz

            // char str1 = 'd'; daha önce tanımlanan değişkenler tekrar tanımlanamaz.

            string str2 = "Bugün hava kar yağışlı";
            str2 = "Yarın hava güneşli olacak...";
            string str3 = "Sıcaklık : ";

            string str4 = str1 + str2 + str3 + 12 +" derece.";

            str3 = ""; //boşluk eklenmiş oluyor
            str3 = null; //hiçbirşey anlamındadır.

            //--------------------------

            int intVar1 = 180;
            int intVar2 = 90;
            int sonuc = intVar1 * intVar2;

            //Console.WriteLine(int.MinValue);
            //Console.WriteLine(int.MaxValue);

            byte bayt1 = 220;
            // 202032501001  --- binlik olarak gösterelim  202.032.501.001
            //long ogrno = 0;
            //Console.WriteLine("Öğrenci Numarası ");
            //ogrno = long.Parse(Console.ReadLine());  //klavyeden değer okur. Enter'a basmak gerekir
            //Console.WriteLine($"Girdiğiniz Öğrenci Numarası : {ogrno}");
            //-------------------------
            // aynı satırda aynı tipli birden fazla değişken tanımlanıp değer atanabilir.
         //   byte b1=4, b2=2, b3=1, bsonuc=0;

            //bsonuc = b1+b2;
            //yukarıdaki satır için açıklama : iki yada daha fazla byte işlem görürse sonuç int olacağından bsonuc değişkeni de byte olduğundan dönüştürme hatası verecektir.
            //Çözüm:
            //intVar1 = b1 + b2; //iki byte tipli değişkenin toplamı intVar1 değişkenine aktarılıyor.
            //long ln = 50;         
            //Console.WriteLine((b1 + ln).GetType()); //işlemin sonucunun tipini öğreniyoruz.

            // ondalıklı veri tipleri ...
            // float, double,  decimal

            //float değişkenlere sabit değerler atarken sayının sonuna f yada F eklenir.
            float fl1 = 12.12345678f;
            Console.WriteLine($"float değeri : {fl1}");
            Console.WriteLine((454755.122).GetType());

            double dbl1=7896541234.789694923752;

            //Console.WriteLine($"double değişkeninin değeri:  {dbl1:N9}");

            //decimal değişkenlere sabit değerler atarken sayının sonuna m yada M eklenir.
            decimal dc1 = 7896541234.789694923752m;
            // Console.WriteLine($"decimal değişkeninin değeri:  {dbl1:N9}");


            // double i = (3d * (5d / 7d));

            double dbl2 = 5;
            double dbl3 = 7;
            double i = 3 * (dbl2 / dbl3);

            // sabit rakamları aritematiksel işlemlerde kullanıyorsak ve ondalıkları kaybetmek istemiyorsak rakamların sonuna d, m, yada f eklerinden birini yazmamız gerekir. Aksi halde ondalıklar kırpılıp sonuç tamsayıya dönüşür.

            // double i = (3d * (5d / 7d));
            Console.WriteLine("1. Sonuç :{0}", i);

            //kesirli kısmı kaybetmek istemiyorsak;
            float x = 3 * (5f / 7f);
            Console.WriteLine("2.Sonuç :{0}", x);
            Console.WriteLine(sizeof(decimal)); // decimal türün kapsadığı bayt sayısını verir

            //---------mantıksal değişkenler
            // 2 değer dönebilir. biri true diğeri false
            bool b1 = true;

            //veritabanın bulunan değerler : kullanıcı = admin şifre 123456
            // ekrandan alınan değerler.
            string kullaniciAdi = "admin", sifre = "123";
            b1 = kullaniciAdi == "admin"; //true
            b1 = kullaniciAdi == "admin" && sifre == "123456"; //false
            b1 = kullaniciAdi == "admin" || sifre == "123456";  // true
            b1 = kullaniciAdi == "ahmet" || sifre == "12345";  // true
            if (b1)
                Console.WriteLine("Oturum Açıldı");
            else
                Console.WriteLine("Bilgiler doğru girilmediği için \nOturum Açılmadı");

            //-------------------
            char c;
            c = 'k';
            Console.WriteLine($"c nin değeri : {c}");

            str1 = str1 + c + " Kütahya" + 'r' + 101+6;
            Console.WriteLine($"str1 in değeri : {str1}");



            Console.ReadLine();



       





        }
    }
}
