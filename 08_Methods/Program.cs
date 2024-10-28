using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metodlar
            //() ile bitenler metoddur.
            //Geriye Değer döndürmeyen metodlar
            //Customer-->Listele,Ekle,sil,güncelle
            //void
            //void Customerlist()
            // {
            //     Console.WriteLine("Ali yıldız");
            //     Console.WriteLine("ayşe yıldız");
            //     Console.WriteLine("merve çınar");
            // }
            // Customerlist();

            //void sun()
            //    {
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //sun();




            #endregion

            #region Geriye değer döndürmeyen parametrili metodlar
            //void writemetod(string customername)
            //{ Console.WriteLine(customername); }
            //writemetod("sıla karataş");

            //void customercard(string name, string surname)
            //{ Console.WriteLine("müşteri:"+name+" "+surname); }
            //customercard("sıla", "karataş");
            //customercard("duru", "su");

            #endregion

            #region Geriye değer döndürmeyen int parametrili metodlar
            //void sum(int number1,int number2,int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //sum(4, 5, 6);

            #endregion

            #region Geriye değer döndüren metodlar
            //string customername()
            //{
            //    return "buse yıldız";
            //}
            //customername();



            //string studentcard()
            //{
            //    string name = "ali";
            //    string surmame = "kaya";
            //    return name +" "+ surmame;

            //}
            //Console.WriteLine(studentcard());


            #endregion

            #region Geriye değer dööndüren string parametrili metodlar

            //string countrycard(string countryname, string capital, string flagcolor)
            //{
            //    string cardinfo = "ülke adı: " + countryname + "-başkent: " + capital + "-bayrak rengi: " + flagcolor;
            //    return cardinfo;
            //}
            //string x, y, z;

            //Console.Write("ülke adını giriniz: ");
            //x=Console.ReadLine();

            //Console.Write("başkenti giriniz: ");
            //y=Console.ReadLine();

            //Console.Write("bayrak rengini giriniz: ");
            //z=Console.ReadLine();

            //Console.WriteLine(countrycard(x,y, z));
            //Console.WriteLine(countrycard("türkiye","ankara","beyaz-kırmızı"));
            #endregion

            #region Geriye değer dööndüren int parametrili metodlar
            //int sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return  result;
            //}
            //Console.WriteLine(sum(33, 44));
            //Console.WriteLine(sum(68, 81));
            //Console.WriteLine(sum(30, 42));
            //Console.WriteLine(sum(90, 67));


            #endregion

            #region Örnek uygulama
            //string examresult(string student,int exam1,int exam2,int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return "öğrenci sınavdan geçti";
            //        return student+"isimli öğrenci sınavı geçti"+"ortalama"+result;
            //    }
            //    else
            //    {
                    
            //        return student + "isimli öğrenci sınavı kaldı" + "ortalama" + result;
            //    }
            //}
            //Console.WriteLine(examresult("ali", 50, 60, 70));
            //Console.WriteLine(examresult("ayşe", 90, 80, 70));

            #endregion

            Console.Read();
        }
    }
}
