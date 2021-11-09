using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;

        //CONSTRUCTOR  BOŞ CONSTRUCTOR CLASS I NEWLEDİĞİMİZ ZAMAN OTAMATİk ÇALIŞIR.
        public MyList()
        {
            items = new T[0]; // burada amaç boş constructor olluşturup listemiz kullanılacağı zaman arkaplanda bir tane 0
                                // elemanlı dizi oluşturmak.
        }
         public void Add(T item)
        {
            T[] tempItems = items;                      // boş dizi tanımıyoruz. Sebebi yeni dizi oluşturduğumuzda 
            items = new T[items.Length + 1];
            for (int i = 0; i < tempItems.Length; i++)
            {
                items[i] = tempItems[i];
            }
            items[items.Length - 1] = item;
            
        }

        public int Lenght
        {
            get { return items.Length; }
        }

        public T[] Item
        { 
            get { return items; }
        }

    }
}
