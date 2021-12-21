using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hazır Fonksiyonlar 
            //String Fonksiyonlar 
            string strMesaj = "Bugun hava ne guzel...";


            Console.WriteLine(strMesaj.Contains("ne"));
            //metodların yanında aşağı doğru ok olursa extension metod demektir.ve sabittirler(sınıfa özel değildir.).işaret yoksa sadece o sınıfa(string) aittir.

            Console.WriteLine(strMesaj.IndexOf('h')); //icinde var mı varsa kaçıncı sırada
            Console.WriteLine(strMesaj.IndexOf("ne")); //""""""""""""""""""""""""""""""""""
            Console.WriteLine(strMesaj.IndexOf("Mars")); 

            Console.WriteLine(strMesaj.Insert(0, "Hey,")); //içine sonradan bişeyler yazdırmak için.
            Console.WriteLine(strMesaj.Insert(strMesaj.Length,"Hey,"));

            Console.WriteLine(strMesaj.Remove(5)); //5ten sonrasını silmek için 
            Console.WriteLine(strMesaj.Remove(6,4)); // 6dan sonra 4 karakter silmek için.

            Console.WriteLine(strMesaj.Replace('a', 'i')); //aharfiyle i harfini değiştir.

            Console.WriteLine(strMesaj.Split('a','i'));
            foreach (var item in strMesaj.Split('a' , 'e'))  //ade ve e de ayır ve o harfleri yazma
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(strMesaj.Substring(6)); //6dan öncesini silmek için 


            Console.WriteLine(strMesaj.ToUpper()); //büyük hafre çevirir.
            Console.WriteLine(strMesaj.ToLower()); //küçük harfe çevirir.

            Console.WriteLine(Math.Pow(9,2)); // mat işlemleri için kullanılır.farklı metodları vardır.9un karesi 81 gibi işlemler.




        }

    }
}
