using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTypes
{
    class MyDictionary<Key_T, Value_T>
    {
        Key_T[] _arrayKey;          // key değerlerini tutacak bir dizi oluşturdum
        Value_T[] _arrayValue;      // value değerlerini tutacak bir dizi oluşturdum
        public MyDictionary()
        {
            _arrayKey = new Key_T[0];                                   //keys için 0 elemanlı boş dizi oluşturulur
            _arrayValue = new Value_T[0];                               //values için
        }

        //MyDictionary için eleman ekleme metodu
        public void Add(Key_T anahtar, Value_T deger)                   //gelen key ve value değerlerini eklemek için fonksiyon yazılır
        {
            Key_T[] tempKeyArray = _arrayKey;                           //eklenen ilk key leri tutmak için geçici bir dizi oluşturulur
            Value_T[] tempValueArray = _arrayValue;

            _arrayKey = new Key_T[_arrayKey.Length + 1];                //yeni key alabilmek için key dizisinin boyutunun bir fazlası boyutta dizi oluşturulur
            _arrayValue = new Value_T[_arrayValue.Length + 1];

            //temp deki elemanlar alınır
            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                _arrayKey[i] = tempKeyArray[i];
                _arrayValue[i] = tempValueArray[i];
            }
            _arrayKey[_arrayKey.Length - 1] = anahtar;                  // yeni eklenen key, key dizisinin sonuna eklenir
            _arrayValue[_arrayValue.Length - 1] = deger;
        }

        //MyDictionary eleman sayısını verir
        public int Count
        {
            get { return _arrayKey.Length; }
        }

        //MyDictionary eleman listeleme (NOT!! Sadece elemanları eklediğini görmek için yazılmıştır)
        public void Key_Value()
        {
            for (int i = 0; i < _arrayKey.Length; i++)
            {
                Console.WriteLine(_arrayKey[i] + "     ---->    " + _arrayValue[i]);
            }
        }

    }
}
