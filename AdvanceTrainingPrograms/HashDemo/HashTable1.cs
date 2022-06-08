using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTrainingPrograms.HashDemo
{
    internal class HashTable1
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add(new Stud(1, "OM"),9768656016);
            ht.Add(new Stud(1, "OM"), 9768656016);
            ht.Add(new Stud(1, "OM"), 9768656016);
            ht.Add(new Stud(1, "OM"), 9768656016);

            foreach(DictionaryEntry obj in ht)
            {
                Console.WriteLine(obj.Key + " " + obj.Value);
            }
        }
    }
    class Stud
    {
        int Sid;
        string nm;

        public Stud(int sid, string nm)
        {
            Sid1 = sid;
            this.Nm = nm;
        }

        public int Sid1 { get => Sid; set => Sid = value; }
        public string Nm { get => nm; set => nm = value; }

        public override bool Equals(object? obj)
        {
            return obj is Stud stud &&
                   Sid == stud.Sid &&
                   nm == stud.nm;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Sid, nm);
        }
    }
}
