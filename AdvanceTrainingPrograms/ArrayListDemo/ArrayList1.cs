using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTrainingPrograms.ArrayListDemo
{
    internal class ArrayList1
    {      
            int orderid;
            string custname;
            string city;
            ArrayList item;

        public ArrayList1(int orderid, string custname, string city, ArrayList item)
        {
            this.Orderid = orderid;
            this.Custname = custname;
            this.City = city;
            this.Item = item;
        }

        public int Orderid { get => orderid; set => orderid = value; }
        public string Custname { get => custname; set => custname = value; }
        public string City { get => city; set => city = value; }
        public ArrayList Item { get => item; set => item = value; }
    }
    class OrderTest1
    {
        public static void Main(string[] args)
        {
            ArrayList orderlist = new ArrayList();

            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("\nEnter the OrderId, CustName, City : ");
                int OrderId = int.Parse(Console.ReadLine());
                string CustName = Console.ReadLine();
                string City = Console.ReadLine();

                Console.Write("\nEnter number of item you will order : ");
                int OrderNum = int.Parse(Console.ReadLine());

                ArrayList ItemList = new ArrayList();
                for (int j = 0; j < OrderNum; j++)
                {
                    Console.Write("\nAdd {j} item in your order : ");
                    string item = Console.ReadLine();
                    ItemList.Add(item);
                }
                ArrayList1 or = new ArrayList1(OrderId, CustName, City, ItemList);
                orderlist.Add(or);
            }

        }
    }
    
}
