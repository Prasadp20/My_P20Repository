using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTrainingPrograms.ArrayListDemo
{
    internal class OrderDetail007
    {
        string CustName;
        string MobNo;
        int OrderNo;
        ArrayList Menu;

        public OrderDetail007(string custName, string mobNo, int orderNo, ArrayList menu)
        {
            CustName1 = custName;
            MobNo1 = mobNo;
            OrderNo1 = orderNo;
            Menu1 = menu;
        }

        public string CustName1 { get => CustName; set => CustName = value; }
        public string MobNo1 { get => MobNo; set => MobNo = value; }
        public int OrderNo1 { get => OrderNo; set => OrderNo = value; }
        public ArrayList Menu1 { get => Menu; set => Menu = value; }
    }
    internal class ArrayList4
    {
            static void Main(string[] args)
        {
            // personal detail start here
            string name, MobNo;
            while (true)
            {
                Console.Write("Enter your good name : ");
                name = Console.ReadLine().ToUpper();

                Console.Write("\nEnter your mobile number : ");
                MobNo = Console.ReadLine();
                try
                {
                    if (MobNo.Length < 10 || MobNo.Length > 10)
                    {
                        {
                            throw new MobNumberException("\nMobile number must be ten digit\n");
                        }
                    }
                }
                catch (MobNumberException e)
                {
                    Console.Write(e.Message);
                }
                Console.Write("\nConform your personal detail \nIf right press - 1 or wrong press - 0 : ");
                int num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    break;
                }
                else if (num == 0)
                {
                    Console.WriteLine("\nReenter your details : ");
                }
            }// personal detail end here

            // order detail start here
            int count = 0;
            //int flag = 0;
            while (true)
            {
                Console.Write("\nDo you want to order something (yes or no) : ");
                string CustDecision = Console.ReadLine().ToUpper();

                if (CustDecision.Length == 3)
                {
                    ++count;
                    //flag++;
                    for (int i = 1; i < count; i++)
                    {
                        Console.Write("\nEnter number of item you order : ");
                        int orderNo = int.Parse(Console.ReadLine());

                        ArrayList menu = new ArrayList();
                        for (int j = 1; j <= orderNo; j++)
                        {
                            Console.Write("\nOrder your menu : ");
                            string orderitem = Console.ReadLine().ToUpper();
                            menu.Add(orderitem);
                        }

                        Console.Write("\nYour Order {0} items : ", orderNo);
                        foreach (var ob in menu)
                        {
                            Console.Write(ob + " ");                          
                        }

                        Console.WriteLine();

                        count--;

                        OrderDetail007 obj = new OrderDetail007(name, MobNo, orderNo, menu);
                    }                
                }
                else
                {
                    Console.Write("\nThank you for shopping");
                    break;
                }
                // order detail end here
                //Console.Write("\nYour total number of order : " + count);
            }
            Console.ReadLine();
        }
    }
    class MobNumberException : ApplicationException
    {
        public MobNumberException(string txt) : base(txt)
        {

        }
    }
}

