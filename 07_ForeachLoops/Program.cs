using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            // Foreach(1;2;3;4)

            //1:Değişken türü
            //2:Değişken adı
            //3:In 
            //4: Liste,koleksiyon,dizi

            //string[] cities = { "istanbul", "ankara", "bosna", "varşova" };
            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] number = { 666, 888, 111, 2323, 9, 27, 16, 2004, 660 };
            //foreach (int i in number)
            //{
            //    if (i % 2 == 0)
            //    {
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}

            //int[] number = { 666, 888, 111, 2323, 9, 27, 16, 2004, 660 };
            //int total = 0;
            //foreach (int i in number)
            //{
            //    total += i;   
            //}
            //Console.WriteLine(total);           - toplamları yazdırılır-

            //List<int> list = new List<int>()
            //{
            //    1,2,3,4,5,6,7,8
            //};
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "merhaba";
            //foreach (char s in word)
            //{
            //    Console.WriteLine(s);
            //}


            #endregion

            #region Örnek Sınav Sistemi Uygulaması


            //Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            ////öğrenci sayısını kullanıcıdan alma
            //Console.WriteLine("------------------------------------");
            //Console.Write("Sınıfınızda kaç tane öğrenci var: ");
            //int studentcount = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------------");

            ////öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            //string[] studentname = new string[studentcount];
            //double[] studentexamavg = new double[studentcount];

            //for (int i = 0; i < studentcount; i++)
            //{
            //    Console.Write($"{i + 1}.öğrencinin adını giriniz:");
            //    studentname[i] = Console.ReadLine();

            //    double totalexamresult = 0;
            //    //her öğrenci için üç sınav notu girişi
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentname[i]} isimli öğrencinin {j + 1}. sınav notu:");
            //        double value = double.Parse(Console.ReadLine());
            //        totalexamresult += value; //notları topluyoruz
            //    }
            //    studentexamavg[i] = totalexamresult / 3;
            //}

            ////sınav ortalamaları
            //for (int i = 0; i < studentcount; i++)
            //{
            //   Console.WriteLine("---------------------------------");
            //    Console.WriteLine($"{studentname[i]} adlı öğrencinin sınav ortalaması:{studentexamavg[i]}");
                
            //    //öğrencinin geçip kalma durumu
            //    if (studentexamavg[i] < 50)
            //    {
            //        Console.WriteLine($"{studentname[i]} isimli öğrenci sınavdan kaldı.");
            //    }
            //    else{
            //             Console.WriteLine($"{studentname[i]} isimli öğrenci sınavdan geçti."); }
            //}
            //Console.WriteLine("---------------------------------");





            #endregion

            Console.Read();

            }
        }
    }
