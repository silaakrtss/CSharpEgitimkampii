using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for döngüsü
            // Döngüler 1+2+3+4+5+6
            // 3+3=6+4=10+5=15+6=21

            //for(x;y;z)
            //x=başlangıç
            //y=bitiş
            //z=artış-azalış

            //int i;
            //for (i = 1; i <= 5; i++) 
            //{
            //    Console.WriteLine("C# eğitim kampı");
            //}

            //int i;
            //for(i =1 ; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i =3 ; i <=50 ; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue= int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("yaşasın cumhuriyet");
            //}

            #endregion

            #region for döngüsünün karar yapılarıyla kullanılması

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalvolue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totalvolue += i;
            //}
            //Console.WriteLine(totalvolue);


            //int totalvolue=0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalvolue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //    Console.WriteLine("-----");
            //    Console.WriteLine(totalvolue);

            //int count = 0;
            //for (int i = 1; i < 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //int bacterium = 1;
            //for (int i = 1; i<=24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". saat sonundaki bakteri sayısı: " + bacterium);
            //}


            #endregion

            #region while döngüsü
            //while (şart)
            //{
            //    işlemler
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("merhaba döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum=0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            //Klavyeden girilen üç basamaklı sayının basamakları toplamını bulunuz.

            //Console.Write("bir sayı giriniz: ");
            //int numbers=int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;
            //ones = numbers % 10;
            //tens = (numbers % 100)/10;
            //hundreds = numbers / 100; //4,55= 4

            //Console.WriteLine(hundreds + "-" + tens + "-" + ones);
            //sum = hundreds + tens + ones;
            //Console.WriteLine(sum);
           
            #endregion

            Console.Read();


        }
    }
}