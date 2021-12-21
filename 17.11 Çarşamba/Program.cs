using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._11_Çarşamba
{
    class Program
    {
        static bool DiziIcindeAra(int[] sayilar, int sayi,out int indis)
        {
            indis = -1;

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] == sayi)
                {
                    indis = i;
                    return true;
                }
            }
            return true;
        }
        static int DiziIcindeAra(int[] sayilar, int sayi)
        {
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] == sayi)
                {
                    return i;
                }
            }
            return -1;
        }

        static int KarakterSay(string str, params char[] c)
        {
            int sayac = 0;

            for (int i = 0; i <str.Length; i++)
            {
                for (int j = 0; j < c.Length; j++) 
                {
                    if (str[i] == c[j])
                        sayac++;
                }
            }
            return sayac;
        }

        static void Main(string[] args)
        {
            //Soru1:Öyle bir metod yazınızki kendisine parametre olarak gönderilen bir dizi içerisindeki istenilen elemanı bulsun ve onun indis bilgisini versin.

            //Soru2:Aynı metodu aşırı yükleyin.

            //Soru3:bir string ifade içerisinden karakterlerden toplam kaçar tane olduğunu bulan kodu yazınız.('a' , 'e').

            int[] dizi1 = { 23, 256, 156, 156, 223, 9, 1, 95 };
            bool varmi = DiziIcindeAra(dizi1, 156, out int idx);
            Console.WriteLine(varmi + " " + idx );

            int index = DiziIcindeAra(dizi1, 66);
            Console.WriteLine(index);

            string strMesaj = "Merhaba Dünya";
            int say = KarakterSay(strMesaj, 'a', 'e', 'ü');
            Console.WriteLine(say);


        }
    }
}
