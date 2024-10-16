using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adam_Asmaca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sözcük Kaynakları__Rasgele Seçim__Rasgele Seçimi Atama
            string[] sözcükler = new string[] { "ANKARA", "YAZILIM", "BİLGİSAYAR", "UYGULAMA", "GELİŞTİRMEK" };
            Random rasgele = new Random();
            string rasgele_seçilen_sözcük = sözcükler[rasgele.Next(0, sözcükler.Length)];

            // Puan değişkenini oluşturma
            int puan = 0;

            // Oyun için seçilen kelime kadar"_" oluşturma
            char[] alttre = new char[rasgele_seçilen_sözcük.Length];
            for(int i = 0; i < alttre.Length ; i++)
            {
                alttre[i] = '_';
            }

            //Asıl işlemlerin olacğı döngüler
            do
            {
                bool kol = false;

                // "_" karakterini ekrana yazdırma
                foreach(var item in alttre)
                {
                    Console.Write(item + " ");
                }

                // Oyuncudan harf isteme
                Console.WriteLine();
                Console.WriteLine("Ekrana bir harf giriniz");
                char kl_harf = char.Parse(Console.ReadLine().ToUpper());

                // Girilen harf ile olması gereken harfleri kontrol etme ve değiştirme
                for (int i = 0; i < rasgele_seçilen_sözcük.Length; i++)
                {
                    if(kl_harf == rasgele_seçilen_sözcük[i])
                    {
                        alttre[i] = kl_harf;
                        kol = true;
                    }

                }

                //Puan durumunu kontrol etme
                if (kol == true)
                    puan += 30;
                else
                    puan -= 30;
                Console.WriteLine("PUAN DURUMU =" +puan);

            } while (true);
            Console.ReadKey();
        }
    }
}
