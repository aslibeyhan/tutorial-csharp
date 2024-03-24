using Business.Concretes;
using Entities.Concretes;
namespace intro

{
    public class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();
            Vatandas vatandas1 = new Vatandas();
            SelamVer(isim: "asli1");
            SelamVer(isim: "asli2");
            SelamVer(isim: "asli3");
            SelamVer();


            int sonuc = Topla(3, 5);

            string ogrenci1 = "Asli";
            string ogrenci2 = "Koray";
            string ogrenci3 = "Burak";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Asli";
            ogrenciler[1] = "Koray";
            ogrenciler[2] = "Burak";

            ogrenciler = new string[4];
            ogrenciler[3] = "melisa";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Muğla" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "Aslı";
            person1.LastName = "Beyhan";
            person1.DateOfBirthYear = 2001;
            person1.NationalIdentity = 12345;


            Person person2 = new Person();
            person2.FirstName = "Murat";

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add(item: "Adana 1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }
        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("merhaba " + isim);
        }
        static int Topla(int sayi1 = 5, int sayi2 = 15)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc.ToString());
            return sonuc;
        }

        private static void Degiskenler()

        {
            string mesaj = "merhaba";
            double tutar = 100000; //db den gelir
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Asli";
            string soyad = "Beyhan";
            int dogumYili = 2001;
            long tcNo = 12345678910;

            Console.WriteLine(tutar * 1.18);
            Console.WriteLine(tutar * 1.18);
        }
    }
    //pascal casing
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}