using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTrainingPrograms.HashDemo
{
    internal class HashTable2
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList()
            {
                "Sun","Mon","Tue","Wed","Sun","Mon","Tue","Sun","Sat",
            };

            //string s = "INDIA";

            Hashtable ht = new Hashtable();

            foreach(dynamic data in al)
            {
                if(ht.ContainsKey(data))
                {
                    int value = (int)ht[data];  
                    ht[data] = value + 1;                 
                }
                else
                {
                    ht.Add(data, 1);
                }
            }
            foreach(DictionaryEntry v in ht)
            {
                Console.WriteLine(v.Key + "=>" + v.Value);
            }
        }
    }
}
