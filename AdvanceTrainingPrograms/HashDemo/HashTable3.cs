using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AdvanceTrainingPrograms.HashDemo
{
    internal class HashTable3
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add(1, "Hashirama");
            ht.Add(2, "Tobirama");
            ht.Add(7, "Naruto");
            ht.Add(4, "Saratobi");
            ht.Add(3, "Minato");
            ht.Add(5, "Tsunade");
            ht.Add(6, "Kakashi");
            ht.Add(8, "Sasuke");
            ht.Add(9, "Obito");
            ht.Add(10, "Itachi");



            foreach (DictionaryEntry Hokage in ht)
            {
                Console.WriteLine(Hokage.Key + "==>" + Hokage.Value);
            }
            Console.ReadLine();
        }
    }
}
