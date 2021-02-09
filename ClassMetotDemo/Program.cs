using System;

namespace ClassMetotDemo
{
    public class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Name = "Merve";
            musteri1.Surname = "Karabekmez";
            musteri1.PhoneNo = 123456789;

            Musteri musteri2 = new Musteri();
            musteri2.Name = "Mustafa";
            musteri2.Surname = "Karabekmez";
            musteri2.PhoneNo = 345245679;






            MusteriManager musteriManager = new MusteriManager();


            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            Console.WriteLine("-------------------");
            musteriManager.Delete(musteri1);
            musteriManager.Delete(musteri2);


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Name + " " + musteri.Surname + " ==> " + musteri.PhoneNo);
            }
            musteriManager.List();
        }

    }
}
