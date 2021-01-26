using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 789;
            musteri1.Ad = "Zeynep";
            musteri1.Soyad = "Yılmaz";
            musteri1.Kredi = "Taşıt Kredisi";
            musteri1.KrediAy = 48;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 790;
            musteri2.Ad = "Doğan";
            musteri2.Soyad = "Yılmaz";
            musteri2.Kredi = "Konut Kredisi";
            musteri2.KrediAy = 120;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.Kredi);
                Console.WriteLine(musteri.KrediAy);
                Console.WriteLine("------------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);

        }
    }
}
