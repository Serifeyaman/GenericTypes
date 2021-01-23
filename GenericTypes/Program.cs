using System;
using System.Collections.Generic;

namespace GenericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary Sınıfı");

            Dictionary<int, string> sehirler = new Dictionary<int, string>();             
            Console.WriteLine("Eleman Sayısı: " + sehirler.Count);   // eleman yokken eleman sayısı 0 olacak

            sehirler.Add(58, "Sivas");
            sehirler.Add(38, "Kayseri");
            sehirler.Add(06, "Ankara");

            Console.WriteLine("Eleman Sayısı: " + sehirler.Count);        //eleman eklendikten sonraki sayısı

            Console.WriteLine("Plakalar      Şehirler");
            Console.WriteLine("---------------------------");
            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir.Key + "     ---->    " + sehir.Value);
            }

            Console.WriteLine("***************************");
            Console.WriteLine("MyDictionary Sınıfı");
            //Benim oluşturduğum dictionary 
            MyDictionary<int, string> myDict = new GenericTypes.MyDictionary<int,string>();

            Console.WriteLine("Eleman Sayısı: " + myDict.Count);        //eleman eklenmeden önceki sayısı

            myDict.Add(25, "Erzurum");              //eleman ekleme
            myDict.Add(58, "Sivas");
            myDict.Add(01, "Adana");

            Console.WriteLine("Eleman Sayısı: " + myDict.Count);        //eleman eklendikten sonraki sayısı

            Console.WriteLine("Plakalar      Şehirler");
            Console.WriteLine("---------------------------");
   
            myDict.Key_Value();                     //elemanları listeleme
        }
    }
}
