using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
      
        public void Ekle(Musteri musteri)

        {


            Console.WriteLine("Müşteri Eklendi :" + musteri.Name + "  " + musteri.Surname);


        }
        public void Delete(Musteri musteri)
        {

            Console.WriteLine("Müşteri Silindi: " + musteri.Name + "  " + musteri.Surname);

        }
        public void List()
        {

            Console.WriteLine("liste eklendi");
        }

    }


}

