using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_mainsubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yazdırmakomutları
            ////Console.WriteLine("Merhaba Dünya");
            //// Console.Write("Selam");

            //Console.WriteLine("***** Yemek Katagorileri");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-Tatlılar");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Katagorileri *****");

            #endregion
            #region String Değişkenler

            //string
            //Değişken_adı değişken_Türü;

            //string name;
            //name = "sıla";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerEmail , district, city;
            //string customerPhone;

            //customerName = "ali";
            //customerSurname = "karataş";
            //customerEmail = "deneme@gmail.com";
            //customerPhone = " +09 500 400 30 20";
            //district = "sakarya";
            //city = "sapanca";

            //Console.WriteLine("*** Rezervasyon Kartı ***");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("mail:" + customerEmail);   
            //Console.WriteLine("iletişim:" + customerPhone);
            //Console.WriteLine("adres:" + city + "/" + district);
            //Console.WriteLine("---------------------------------------");

            //customerName = "mehmet";
            //customerSurname = "karataş";
            //customerEmail = "deneme@gmail.com";
            //customerPhone = " +09 500 400 30 20";
            //district = "sakarya";
            //city = "sapanca";

            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("mail:" + customerEmail);
            //Console.WriteLine("iletişim:" + customerPhone);
            //Console.WriteLine("adres:" + city + "/" + district);
            //Console.WriteLine("---------------------------------------");
            #endregion
            #region İnt Değişkenler 

            //int number=24;
            //Console.WriteLine(number);

            int hamburgerprice = 300;
            int cokeprice = 35;
            int waterprice = 10;
            int friesprice = 50;
            int pizzaprice = 250;
            int lemonadeprice = 30;

            Console.WriteLine("**** Restorant Fiyat Listesi ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger:" + hamburgerprice + "TL");
            Console.WriteLine("-----Kola:" + cokeprice + "TL");
            Console.WriteLine("-----Su:" + waterprice + "TL");
            Console.WriteLine("-----patates:" + friesprice + "TL");
            Console.WriteLine("-----pizza:" + pizzaprice + "TL");
            Console.WriteLine("-----limonata:" + lemonadeprice + "TL");
            Console.WriteLine();
            Console.WriteLine("**** Restorant Fiyat Listesi ****");

            Console.WriteLine();
            int hamburgercount;
            int cokecount;
            int watercount;
            int friesprcount;
            int pizzaprcount;
            int lemonadecount;

            int totalhamburgerprice;
            int totalcokeprice; 
            int totalwaterprice;
            int totalfriesprice;
            int totalpizzaprice;
            int totallemonadeprice;

            hamburgercount = 3;
            cokecount = 3;
            watercount = 3;
            friesprcount = 1;
            pizzaprcount = 0;
            lemonadecount = 0;



            #endregion
            Console.Read();



        }
    }
}
