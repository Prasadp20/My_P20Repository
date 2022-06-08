using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTrainingPrograms.StackDemo
{
    internal class Stack1
    {
        static void Main(string[] args)
        {
            // It works on Last In First Out (LIFO)
            Stack s = new Stack();
            s.Push("Naruto");
            s.Push("Sasuke");
            s.Push("Sakura");

            // Push - Add
            // Pop - Remove
            foreach(object ob in s)
            {
                Console.Write(ob + " ");
            }

            string d = (string)s.Pop();
            Console.WriteLine("\nRemove ==> " + d);

            Console.Write("Peek ==> " + s.Peek());

            Console.Write("\nFinal team ==> ");
            foreach (object ob in s)
            {
                Console.Write(ob + " ");
            }
        }
    }
}
