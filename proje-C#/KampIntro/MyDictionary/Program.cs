//using system;
//using system.collections.generic;
//using system.linq;
//using system.text;
//using system.threading.tasks;
//namespace mydictionary
//{
//    class program
//    {
//        public static int ogretmenler { get; private set; }

//        static void main(string[] args)
//        {

//            mydictionary<string> isimler = new mydictionary<string>();

//            isimler.add("cansu");

//            console.writeline(isimler.lenght);

//            isimler.add("engin");

//            console.writeline(isimler.lenght);

//            foreach (var isim in isimler.ıtems)
//            {
//                console.writeline(isim);

//            }


//        }

//        internal class mydictionary<t>
//        {
//            public bool lenght { get; internal set; }
//            public ıenumerable<object> ıtems { get; internal set; }

//            internal void add(string v)
//            {
//                throw new notımplementedexception();
//            }



using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> isimler = new MyDictionary<string>();

            isimler.Add("Cansu");

            Console.WriteLine(isimler.Lenght);

            isimler.Add("Engin");

            Console.WriteLine(isimler.Lenght);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);

            }
        }
    }
}

