using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
     class SepetManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Ekleme işleminiz gerçekleştirildi  ") ;
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Silme işleminiz gerçekleştirildi ") ;

        }

        public void Listeleme (Musteri musteri)
        {
            Console.WriteLine("Listeleme işleminiz gerçekleştirildi ");

        }
    }
}
