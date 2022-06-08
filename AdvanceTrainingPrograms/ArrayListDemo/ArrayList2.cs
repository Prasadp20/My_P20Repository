using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTrainingPrograms.ArrayListDemo
{
    class ArrayList2
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();

            Console.WriteLine("Entre the number friend you have : ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.Write("Enter you friends name : ");
                string name = Console.ReadLine();
                arr.Add(name);
            }
            foreach(var obj in arr)
            {
                Console.WriteLine(obj+" ");
            }
        }
    }
}
