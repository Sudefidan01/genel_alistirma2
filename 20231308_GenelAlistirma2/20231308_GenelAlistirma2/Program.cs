using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231308_GenelAlistirma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Soru 2
            //Bir yüz boyama etkinliğine katılacak olan çocukların adedini kullanıcıdan isteyiniz.Girilen adet kadar çocuğun doğum yılını yazınız.Etkinliğe 4 yaşından küçük ve 13 yaşından büyük çocuk katılamaz.Eğer Bu yaş aralığı dışında bir çocuk eklenmeye çalışırsa kullanıcıya uyarı gösterin.Tüm Çocukların yaşları girildiğinde girilen çocukların hepsini ayrı olarakda etkinliğe katılabilecek çocukların yaşlarını gösterin
            Console.Write("Etkliniğe Kayıt Olacak Kişi Sayısını Girin : ");
            int adet=int.Parse(Console.ReadLine());

            int[] dogumYili= new int[adet];
            int simdikiYil = DateTime.Now.Year;
            for (int i = 0; i < dogumYili.Length; i++)
            {
                Console.Write((i+1)+".Çocuğun Yılını Girin : ");
                int yil= int.Parse(Console.ReadLine());
                dogumYili[i] = simdikiYil - yil;
                if (dogumYili[i]<4 || dogumYili[i]>13)
                {
                    Console.WriteLine("Malesef bu çocuk etkinliğe katılamaz");
                }

            }
            Console.Clear();
            Array.Sort(dogumYili);
            Console.WriteLine("-----Listeye Kayıt Olan Kişilerin Yaşlar -----");
            foreach (var item in dogumYili)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---Etkinliğe Katılabilenlerin Yaşlarının Listesi ------");
            foreach (var item in dogumYili)
            {
                if (item > 4 && item < 13)
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadKey();
        }
    }
}
