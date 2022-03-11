using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GedizMYO_Hafta3_1
{
    
    class turDonusumu
    {
        static void Main(string[] args)
        {
            //byte b1 = 78;
            //int intVar1 = 1500;
            //intVar1 = b1;
            //decimal d1 = 147.5m;
            //Console.WriteLine($"d1 değeri : {d1}");
            //d1 = intVar1;
            //Console.WriteLine($"d1 değeri : {d1}");

            //Console.WriteLine("--------------------");
            //byte b1 = 5, b2 = 15;
            //int i_sonuc = b1 + b2;
            //Console.WriteLine($"işlemin tipi : {(b1+b2).GetType()}");

            // Console.WriteLine("--------------------");
            //int intVar1 = 200;
            //byte b1 = 15;
            //b1 = (byte)intVar1;
            //Console.WriteLine($"b1 değeri : {b1}");
            //intVar1 = 1580;
            //double d1 = 15.80;
            //b1 = (byte)intVar1;
            //Console.WriteLine($"b1 son değeri : {b1}");
            //b1 = (byte)d1;
            //Console.WriteLine($"b1 son değeri : {b1}");
            //string str = "b1 son değeri";
            //// str += b1;
            //str += b1.ToString();
            //string str2 = b1.ToString();
            //Console.WriteLine($"b1 son değeri : {b1}");

            //string b3 = 12.5.ToString();  //float bir sayıyı stringe çevirdik.
            //string b4 = 'k'.ToString();  //char tipli değişkeni stringe çevirdik.

            Console.WriteLine("değişkeni 1 artırma ve 1 eksiltme işlemleri");
            Console.WriteLine("postfix(sonek) yöntemi");
            int toplam = 0;
            int intVar = 10;
            // intVar = intVar + 1;
            //yada
            // intVar++;  //postfix yöntemi ile değişken değeri 1 artırıldı.
            //Console.WriteLine("postfix yöntemi ile artırma ");
            //toplam = intVar++;
            //Console.WriteLine($"toplam değişkeni değeri : {toplam}");
            //Console.WriteLine($"intVar değişkeni değeri : {intVar}");
            ////   ++intVar;  // prefix yöntemi ile değiken değeri 1 artırıldı.
            //Console.WriteLine("prefix yöntemi ile artırma ");
            //toplam = 0;
            //intVar = 10;
            //toplam = ++intVar;
            //Console.WriteLine($"toplam değişkeni değeri : {toplam}");
            //Console.WriteLine($"intVar değişkeni değeri : {intVar}");
            //Console.WriteLine( "---------------");
            //Console.WriteLine("değişkeni 1 eksiltme yöntemi");
            //Console.WriteLine("postfix(sonek) yöntemi");
            // toplam = 0;
            // intVar = 10;
            //toplam = intVar--;
            //Console.WriteLine($"toplam değişkeni değeri : {toplam}");
            //Console.WriteLine($"intVar değişkeni değeri : {intVar}");

            //Console.WriteLine("prefix(önek) yöntemi");
            //toplam = 0;
            //intVar = 10;
            //toplam = --intVar;
            //Console.WriteLine($"toplam değişkeni değeri : {toplam}");
            //Console.WriteLine($"intVar değişkeni değeri : {intVar}");

            string first = "5";
            string second = "7";
            int sum = 0;
            sum = int.Parse(first) + int.Parse(second);
          //  Console.WriteLine($"sum değişkeni değeri : {sum}");
            Console.WriteLine("-------------");
            first = "5a";
           // sum = int.Parse(first) + int.Parse(second);
          //  Console.WriteLine($"sum değişkeni değeri : {sum}");
            // yukarıdaki işlemde format hatası alırız
            //Özel Durum: System.FormatException: Giriş dizesi doğru biçimde değildi.
            // böyle durumlarda parse yönteminin daha gelişmişi olan tryparse yöntemi kullanılabilir
            first = "5a";
            second = "7";
            int _first, _secon;
            bool f1 = int.TryParse(first, out _first );// _first'ün değeri 0 olur. f1'in değeri false olur.
            bool s1 = int.TryParse(second, out _secon);// _second'ın değeri 7 olur. s1'in değeri true olur.
            if (f1 && s1)
            {
                sum = _first + _secon;
                Console.WriteLine($"Hesaplama Sonucu : {sum}");
            }                
            else
            {
                sum = _first + _secon;
                Console.WriteLine("Dönüştürme işlemi hatalı ...");
                Console.WriteLine($"Hesaplama Sonucu : {sum}");
            }

            double dbl1 = 4788;
            long lng1 = 0;
            lng1 = Convert.ToInt64(dbl1);
            dbl1 = Convert.ToDouble(lng1);
            string x = Convert.ToString(dbl1);
            lng1 = long.Parse("547");
            dbl1 = double.Parse("7854");
            first = "5a";
            //    dbl1 = double.Parse(first); // hata oluşur
            bool bool1 = double.TryParse(first, out double db);
            if (bool1)
                Console.WriteLine(db + 10); 
            else
                Console.WriteLine("hata oluştu...");
            Console.WriteLine("-------------------");
            int valueCasting = (int)1.5m; //  ondalık kısmı yok olur
            Console.WriteLine(valueCasting);
            int valueConvert = Convert.ToInt32(1.4m); // ondalık kısmı yukarı yuvarlanır
            Console.WriteLine(valueConvert);

        }


    }
}
