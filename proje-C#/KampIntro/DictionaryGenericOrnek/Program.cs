using System;

namespace DictionaryGenericOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ogretmenler = new Dictionary<int, string>();
            ogretmenler.Add(101, "Cansu");
            ogretmenler.Add(102, "Engin");
            ogretmenler.Add(103, "Kerem");
            ogretmenler.Add(104, "Yağmur");
            ogretmenler.Add(105, "Barış");
            ogretmenler.Add(106, "Deniz");

            for (int i = 0; i < ogretmenler.Count(); i++)
            {
                Console.WriteLine(ogretmenler.keys[i] +"  " +ogretmenler.values[i] );
            }
            Console.WriteLine(  "Öğretmenler sayısı : "+  ogretmenler.Count());
            Console.ReadKey();
        }
    }
 


   class Dictionary<TKey,TValue>
    {//Key ve Value dizileri oluşturduk
        public TKey[] keys;
        public TValue[] values;

        public Dictionary()

        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {

            TKey[] tempArray1 = keys;
            TValue[] tempArray2 = values;

            keys = new TKey[keys.Length + 1];
            for (int i = 0; i < tempArray1; i++)
            {
                keys[i] = tempArray1[i];
            }

            keys[keys.Length - 1] = key;
            values = new TValue[values.Length + 1];
            for (int i = 0; i < tempArray2; i++)
            {
                value[i] = tempArray2[i];
            }

            values[values.Length - 1] = value;

        }

        public int Count()
        {
            return keys.Length;

        }



    internal class MyDictionary<T1, T2>
    {
        internal void Add(int v1, string v)
        {
            throw new NotImplementedException();
        }

        internal int Count()
        {
            throw new NotImplementedException();
        }
    }
