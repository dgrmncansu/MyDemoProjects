using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace DictionaryGenericOrnek
{
    class MyDictionary
    {
   
        public MyDictionary()
        {
            string[] items;
            //constructor
            public MyDictionary()
            {
                items = new string[0];
            }
            public void Add(int item)
            {

                string[] tempArray = items;
                //  geçici dizi
                items = new string[items.Length + 1];

                for (int i = 0; i < tempArray.Length; i++)
                {
                    items[i] = tempArray[i];
                }

                items[items.Length - 1] = item;


            
             class items
    {
    }
}


        public int Lenght
        {
            get { return items.Length; }
        }

        public string[] Items
        {
            get { return items; }
        }
    }

   

   