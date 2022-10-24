using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Name = "Tuçe";
            musteri1.TCNumber = 2;
            musteri1.LastName = "Durmaz";
            musteri1.Id = 09;


            Musteri musteri2 = new Musteri();
            musteri2.Name = "eçtu";
            musteri2.TCNumber = 5;
            musteri2.LastName = "Durur";
            musteri2.Id = 11;


            Musteri[] musteriler = new Musteri[] { musteri1,musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Name);
                Console.WriteLine(musteri.TCNumber);    
                Console.WriteLine(musteri.LastName);    
                Console.WriteLine(musteri.Id);  

            }


            
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(musteri1); 
            sepetManager.Ekle(musteri2);
            sepetManager.Delete(musteri1);
            sepetManager.Delete(musteri2);
            sepetManager.Listeleme(musteri1);
            sepetManager.Listeleme(musteri2);




        }
    }
}
