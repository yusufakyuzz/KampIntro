using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDictionary
{
    class MyDictionary<K,V>
    {
        K[] anahtar;
        V[] deger;
        K[] geciciAnahtar;
        V[] geciciDeger;

        public MyDictionary()
        {
            anahtar = new K[0];
            deger = new V[0];

        }

        public void Add(K item, V value)
        {
            geciciAnahtar = anahtar;
            geciciDeger = deger;
            anahtar = new K[anahtar.Length + 1];
            deger = new V[deger.Length + 1];

            for(int i=0;i<geciciAnahtar.Length;i++)
            {
                anahtar[i] = geciciAnahtar[i];
                deger[i] = geciciDeger[i];
            }

            anahtar[anahtar.Length - 1] = item;
            deger[deger.Length - 1] = value;

        }

        public int Length()
        {

            return anahtar.Length;
        }
    
    }
}
