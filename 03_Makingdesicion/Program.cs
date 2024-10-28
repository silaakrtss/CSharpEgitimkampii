using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Makingdesicion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if else

            //Console.Write("Lütfen şifre giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd") {
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}


            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Hatalı bilgi");
            //}


            //int number;
            //Console.Write("Bir sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("sayı yanlış");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "hata!";

            //Console.Write("sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average > 50 & average <=70)
            //{
            //    result = "Sonuç orta";
            //}
            //if(average>70 & average <= 85)
            //{
            //    result = "Sonuç iyi";
            //}
            //if(average>85 & average <= 100)
            //{
            //    result = "Sonuç çok iyi";
            //}
            //Console.WriteLine(result);



            //string city;
            //Console.Write("Bir şehir giriniz: ");
            //city = Console.ReadLine();

            //if (city == "ankara" | city == "kocaeli" | city == "düzce" | city == "aksaray")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}


            //Console.Write("Bir Kullanıcı Adı Giriniz: ");
            //string username;
            //username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.Write("kullanıcı adı kabul edilemez!");
            //}
            //else
            //{
            //    Console.Write("hoş geldiniz");
            //}


            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int sayı1= int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int sayı2= int.Parse(Console.ReadLine());

            //int result = (sayı1 % sayı2);

            //Console.Write("Birinci sayının ikinci sayıya bölümünden kalan: " +result);


            //Console.Write("Lütfen sayı giriniz: ");
            //int number= int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("sayı çiftdir");
            //}
            //else
            //{
            //    Console.WriteLine("sayı tektir");
            //}
            #endregion

            #region Char Değişkenleri İle Karar Yapıları

            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'G' | team=='g')
            //{
            //    Console.WriteLine("galatarasay");
            //}
            //if (team == 'B'| team=='b')
            //{
            //    Console.WriteLine("beşiktaş");
            //}
            //if (team == 'F' | team == 'f')
            //{
            //    Console.WriteLine("fenerbahçe");
            //}
            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("***** C# Egitim Kampı Restorant *****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("1-Ana yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri soslu tavuk");
            //    Console.WriteLine("2-Kuru fasulye");
            //    Console.WriteLine("3-Kızartma tabağı");
            //    Console.WriteLine("4-Patlıcan musakka");
            //    Console.WriteLine("5-Fırında somon");
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu pizza");
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //} 
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Su");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();
            //} 
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-triliçe");
            //    Console.WriteLine("2-sütlaç");
            //    Console.WriteLine("3-kazandibi");
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //} 
            #endregion

            #region Switch Case


            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthnumber= int.Parse(Console.ReadLine());

            //switch(monthnumber)
            //{
            //    case 1: Console.WriteLine("ocak"); break;
            //    case 2: Console.WriteLine("şubat"); break;
            //    case 3: Console.WriteLine("mart"); break;
            //    case 4: Console.WriteLine("nisan"); break;
            //    case 5: Console.WriteLine("mayıs"); break;
            //    case 6: Console.WriteLine("haziran"); break;
            //    case 7: Console.WriteLine("temmuz"); break;
            //    case 8: Console.WriteLine("ağustos"); break;
            //    case 9: Console.WriteLine("eylül"); break;
            //    case 10: Console.WriteLine("ekim"); break;
            //    case 11: Console.WriteLine("kasım"); break;
            //    case 12: Console.WriteLine("aralık"); break;
            //    default: Console.WriteLine("hatalı giriş yaptınız"); break ;

            //}
            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("fark: " + result);
            //        break;

            //    case '*':
            //        result = number1 + number2;
            //        Console.WriteLine("çarpım: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("bölüm: " + result);
            //        break;
            //}
            #endregion

            Console.Read();

        }
    }
}