using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace AdvanceTrainingPrograms.HashDemo
{
    internal class HashTable4
    {
        static void Main(string[] args)
        {
            Console.Write("               Menu List\n\n");

            Console.Write("               DRINKS   \n");
            Console.Write("Menu     -     Price   Menu            Price\n");
            Console.Write("Tea -           15    Coffee -          20\n");
            Console.Write("Green Tea -     15    Cold Coffee -     20\n\n");

            Console.Write("               SNAKS   \n");
            Console.Write("  Menu     -   Price     Menu            Price\n");
            Console.Write("Veg Burgur -    100    Veg Pizza -        200\n");
            Console.Write("French Fries  -  70    Chezz Sandwich -   200\n\n");

            ArrayList al = new ArrayList();

            //Console.Write("Enter the name of your friends : ");
            do
            {
                string name;
                int count = 0;
                Console.WriteLine("Order your menu : "); 
                while (true)
                {
                    //Console.Write("Enter the name of your friends : ");
                    name = Console.ReadLine();
                    al.Add(name);
                    count++;
                    if (count == 4)
                    {
                        break;
                    }
                }
                while(true)
                {                  
                    Console.Write("\nDo you want to order again (for yes:1 or no:0) : ");
                    int UserChoise = int.Parse(Console.ReadLine());
                    
                    if (UserChoise == 1)
                    {
                        Console.WriteLine("Order your menu : ");
                        string name1 = Console.ReadLine();
                        al.Add(name1);
                    }
                    else if (UserChoise == 0)
                    {
                        break;
                    }
                }

                break;
            }
            while (true);

            Console.WriteLine("\nYour total orders : ");
            foreach(var ele in al)
            {
                Console.WriteLine(ele + " ");
            }

            Hashtable table = new Hashtable();

            foreach(dynamic data in al)
            {
                if(table.ContainsKey(data))
                {
                    int oldvalue = table[data];
                    table[data] = oldvalue + 1;
                }
                else
                table.Add(data,1);
            }

            Console.WriteLine("\nYour orders with price : ");
            foreach(DictionaryEntry entry in table)
            {
                Console.WriteLine(entry.Key + "-->" + entry.Value);
            }

            
            Console.ReadLine();
        }
    }
}
