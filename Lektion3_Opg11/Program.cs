using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericCardCollection
{
    class CprNr
    {
        public CprNr(String bDate, String sNumber)
        {
            BirthDate = bDate;
            SequenceNumber = sNumber;
        }
        public String BirthDate { get; set; }
        public String SequenceNumber { get; set; }
    }

    class Person
    {
        public Person(CprNr cpr, String navn, String adresse)
        {
            Cpr = cpr;
            Navn = navn;
            Adresse = adresse;
        }
        public CprNr Cpr { get; set; }
        public String Navn { get; set; }
        public String Adresse { get; set; }
    }

    class GenericCollection<TKey, TValue>
    {
        private readonly Dictionary<TKey, TValue> _collection = new Dictionary<TKey, TValue>(); 
        public bool AddElement(TKey k, TValue v)
        {
            if (_collection.ContainsKey(k))
            {
                return false;
            }
            _collection.Add(k, v);
            return true;
        }

        public TValue GetElement(TKey k)
        {
            return _collection[k];
        }

        public int Size()
        {
            return _collection.Count();
        }
    }

    class Program
    {
        static void Main()
        {
            var personCollection = new GenericCollection<CprNr, Person>();

            var morten = new Person(new CprNr("211271", "7777"), "Morten", "Brabrand");
            var karina = new Person(new CprNr("141174", "8888"), "Karina", "Aarhus");

            personCollection.AddElement(karina.Cpr, karina);
            personCollection.AddElement(morten.Cpr, morten);

            //Console.WriteLine("Navn(211271,7777)={0}", personCollection.GetElement(new CprNr("211271", "7777")));

            Console.WriteLine("Size={0}", personCollection.Size());
            Console.ReadLine();
        }
    }
}
