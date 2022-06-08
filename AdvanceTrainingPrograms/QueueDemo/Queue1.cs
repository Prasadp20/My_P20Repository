using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTrainingPrograms.QueueDemo
{
    internal class Queue1
    {
        static void Main(string[] args)
        {
            // It works on First In First Out - FIFO
            Queue qu = new Queue();
            qu.Enqueue("Naruto");
            qu.Enqueue("Sasuke");
            qu.Enqueue("Sakura");
            foreach(object o in qu)
            {
                Console.WriteLine(o);
            }

            string d = (string)qu.Dequeue();
            foreach (object o in qu)
            {
                Console.WriteLine(o);
            }
            // Enqueue - Add
            // Dequeue - Remove

        }
    }
}
