using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTrainingPrograms.ArrayListDemo
{
    class OrderTest0007
    {
        static void Main(string[] args)
        {
            Console.Write("\nEnter number of item you order : ");
            int orderNo = int.Parse(Console.ReadLine());
            int flag = 0, temp = 0, Key = 0, Lock = 0;
            while (true)
            {
                
                Console.Write("Do you want to see menu card : yes or no");
                string word = Console.ReadLine();
                if (word.Length == 3)
                {
                    {
                        Console.Write("Tea, coffee, green tea, masala tea");
                        flag++;
                    }
                    {
                        Console.Write("\nOnion Pizza, mashroom pizzza, pappy panner pizza");
                        temp++;
                    }
                    {
                        Console.Write("\nBurgur, Sandwich");
                        Key++;
                    }
                    {
                        Console.Write("\nVeg shejwan roll, chezz roll, allu roll");
                        Lock++;
                    }
                    string dish = Console.ReadLine();
                }
                /*else
                {
                    Console.Write("Thanks for coming");
                    break;
                } */            
            }
            Console.Write("Your total number of order : " + (flag + temp + Key + Lock));

        }
    }
   
}
