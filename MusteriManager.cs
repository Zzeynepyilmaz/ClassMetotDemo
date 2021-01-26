using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(int id, string musteriAd , string musteriSoyad, string kredi, int krediAy)
        {
            Console.WriteLine("Muşteri eklendi. Müşteri numarası: " + id);
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Adı: " + musteri.Ad);
            Console.WriteLine("Soyadı:" + musteri.Soyad);
            Console.WriteLine("Kredi Türü:" + musteri.Kredi);
            Console.WriteLine("Kredi Ayı:" + musteri.KrediAy);
        }
        public void Silme()
        {

        }
    }
}
