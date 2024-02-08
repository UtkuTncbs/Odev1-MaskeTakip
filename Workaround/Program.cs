using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{

    class Program
    {

        static void Main(string[] args)
        {
            Degiskenler();

            //Vatandas vatandas1 = new Vatandas();

            SelamVer(isim:" Engin");
            SelamVer(isim: " Utku");
            SelamVer(isim: " Ayşe");

            int sonuc = Topla(6,58);

            // Diziler / Arrays

            Person person1 = new Person();
            person1.FirstName = "ENGİN";
            person1.LastName = "DEMİROĞ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 123;


            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";
            //ogrenciler[3] = "İlker";
            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };
            sehirler1 = sehirler2;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1;
            sayi1 = 30;

            foreach (string sehir in sehirler1) 
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Kocaeli 1");
            foreach(var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            Console.WriteLine();

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

        }

        
        
        

        static void SelamVer(string isim = "Belirtilmedi")
        {
            Console.WriteLine("Merhaba" + isim );
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc);
            return sonuc;
        }

        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000; // db'den gelir double ondalık sayı tutabilir
            int sayi = 100; // int sadece tam sayı tutar
            bool girisYapmisMi = false; //true ya da false olarak değerlendirir

            string ad = "Utku";
            string soyad = "Tunçbaş";
            int dogumYili = 2000;
            long tcNo = 12345678910;

            Console.WriteLine(tutar * 1.18);

            Console.WriteLine(mesaj);
        }
    }

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set;}
        public int DogumYili { get; set;}
        public long TcNo { get; set;}
    }
}