using System;
using System.Text;

namespace String_İslemleri1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir cümle girin: ");
            string giris = Console.ReadLine();

            // Substring (boşluk kontrolü ile)
            if (giris.Contains(" "))
            {
                string ilkKelime = giris.Substring(0, giris.IndexOf(' '));
                Console.WriteLine($"İlk kelime: {ilkKelime}");
            }
            else
            {
                Console.WriteLine("Cümlede boşluk bulunamadı, tek kelime girilmiş olabilir.");
            }

            // Replace
            string yeniMetin = giris.Replace("a", "@");
            Console.WriteLine($"'a' harfleri '@' ile değiştirildi: {yeniMetin}");

            // Split ve Join
            string[] kelimeler = giris.Split(' ');
            string tekrarBirleştirildi = string.Join("-", kelimeler);
            Console.WriteLine($"Kelimeler tire ile birleştirildi: {tekrarBirleştirildi}");

            // StringBuilder
            StringBuilder sb = new StringBuilder();
            foreach (string kelime in kelimeler)
            {
                sb.Append(kelime.ToUpper() + " ");
            }
            Console.WriteLine("Büyük harflerle oluşturulmuş metin: " + sb.ToString().Trim());
        }
    }
}
