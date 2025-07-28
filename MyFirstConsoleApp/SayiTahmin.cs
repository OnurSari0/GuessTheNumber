using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    public class SayiTahmin
    {
        // BU METODU DEĞİŞKENLERİMİZİ TANIMLAMAK İÇİN KULLANIYORUZ

        public static void Main(string[] args)
        {
            SayiTahmin_(args);
        }   

        public static void SayiTahmin_(string[] args)
        {
            Console.Title = "Sayı Tahmin Oyunu";
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            Console.SetWindowPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Random randomnumber = new Random();
            int randomnumber_ = randomnumber.Next(0, 100);
            //Console.WriteLine("Rastgele Sayı: " + randomnumber_);    
            Console.WriteLine("Merhaba, Ben Onur. Bu benim Sayı Tahmin Oyunum. Umarım beğenirsin :)");
            Console.WriteLine("Bu oyunda 0 ile 100 arasında rastgele bir sayı tahmin edeceksin. 5 hakkın var. Başarılar dilerim :)");
            Console.WriteLine("Bu oyunu oynarken eğlenmeyi unutma :)");

            int attempts = 5;
            Console.WriteLine("Kalan hakkınız: " + attempts);
            int remainingAttempts = attempts--;

            while (true)
            {
                remainingAttempts--;
                string input = Console.ReadLine();
                if (int.TryParse(input, out int guessedNumber) && guessedNumber >= 0 && guessedNumber <= 100)
                {
                    Console.WriteLine("Tahmininiz: " + guessedNumber);
                    if (guessedNumber == randomnumber_)
                    {
                        Console.WriteLine("Tebrikler, doğru tahmin ettin");
                        break;
                    }
                    if (Math.Abs(guessedNumber - randomnumber_) >= 30)
                    {
                        Console.WriteLine("Soğuk!:( Çok uzak bir tahmin yaptın ");
                    }
                    else if (Math.Abs(guessedNumber - randomnumber_) >= 20)
                    {
                        Console.WriteLine("Ilık!:( Biraz daha yakın bir tahmin yaptın ");
                    }
                    else if (Math.Abs(guessedNumber - randomnumber_) <= 15 && Math.Abs(guessedNumber - randomnumber_) >= 6)
                    {
                        Console.WriteLine("Sıcak! Yaklaştın, denemeye devam et");
                    }
                    else if (Math.Abs(guessedNumber - randomnumber_) <= 5)
                    {
                        Console.WriteLine("Çok Sıcak! Çok Yaklaştın, denemeye devam et");
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir sayı girin (0-100 arası)");
                }
                if (remainingAttempts <= 0)
                {
                    Console.WriteLine("Hakkınız kalmadı, oyunu kaybettiniz. Doğru sayı: " + randomnumber_);
                    break;
                }
            }
            Console.WriteLine("Nasıl oyun ? beğendin mi ?");
            Console.WriteLine("Oyunu tekrar oynamak ister misin? (E/H)");
            string choice = Console.ReadLine()?.ToUpper();
            if (choice == "E")
            {
                SayiTahmin_(args);
            }
            else
            {
                Console.WriteLine("Oyundan çıkılıyor...");
                Environment.Exit(0);
            }
        }

        internal static string GetRandomNumber()
        {
            throw new NotImplementedException();
        }
    }
}
