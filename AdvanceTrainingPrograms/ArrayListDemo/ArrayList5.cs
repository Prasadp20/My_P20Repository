using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTrainingPrograms.ArrayListDemo
{
    internal class ArrayList5
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            int count = 0;

            do
            {
                
                Console.Write("Enter your favourite car brand : ");
                string name = Console.ReadLine();
                list.Add(name);
                count++;

                if(count == 5)
                {
                    break;
                }

            }while (true);

            Console.Write("Famous car brands are : ");
            foreach(var item in list)
            {
                Console.Write(item + " ");
            }

            // Count property
            Console.Write("\nNumber of elements : " + list.Count);

            // Capacity property
            Console.WriteLine("\nCurrent capacity : " + list.Capacity);

            // IsFixedSize property
            Console.WriteLine(list.IsFixedSize);

            // FixedSize property
            ArrayList myListfixed = ArrayList.FixedSize(list);
            Console.WriteLine(myListfixed.IsFixedSize);

            // ReadOnly property
            Console.WriteLine("Is array list is read-only : " + list.IsReadOnly);

            // IsSynchronized property
            Console.WriteLine("My 1st ArrayList is {0}",list.IsSynchronized? " Synchronized " : " not Synchronized ");

            ArrayList myList = ArrayList.Synchronized(list);
            Console.WriteLine("My 2nd ArrayList is {0}", myList.IsSynchronized ? " Synchronized " : " not Synchronized ");

            ArrayList arr = new ArrayList();

            arr.Add("Naruto");
            arr.Add("Sasuke");
            arr.Add("Sakura");
            arr.Add("Hinata");
            arr.Add("Neji");
            arr.Add("Lee");

            foreach(var str in arr)
            {
                Console.Write(str + " ");
            }

            // Item[int32] property
            Console.WriteLine("After int[32] property : ");

            arr[1] = "Hinata";
            arr[3] = "Sasuke";

            foreach (var str in arr)
            {
                Console.Write(str + " ");
            }

            // SyncRoot property
            lock (arr.SyncRoot) 
            {
                foreach (object obj in arr)
                    Console.Write(obj + " ");
            }






        }
    }
}
