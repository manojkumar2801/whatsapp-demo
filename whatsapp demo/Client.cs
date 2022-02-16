using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whatsapp_demo
{
    public class Client

    {
        #region declaration
        public List<Client> Contact_bookc1 = new List<Client>();
        long ph_num;
        List<long> login = new List<long>();//list storing for register num
        List<string> namL = new List<string>();// list for storing register name
        string client_name;
        public int sender_id { get; set; }
        public int receiver_id { get; set; }
        public string message { get; set; }
        public messageStatus status { get; set; }
        public DateTime created_at { get; set; }
        #endregion
        public Client()
        {

            client_name = Client_name;

            ph_num = Ph_num;
        }
        public enum messageStatus
        {
            Sent,
            Delivered
        }

        
        

        public Client(string a, long b)
        {
            Client_name = a;
            Ph_num = b;
            
        }
        public string Client_name
        {
            get { return client_name; }
            set { client_name = value; }
        }

        public long Ph_num { get; internal set; }
        public void Login() //login code
        {
            login.Add(1234567890);
            namL.Add("manoj");



            Console.Write("HEllo can you please enter the num to login :");
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine("num: " + number);
            login.Add(number);
            if (login[0] == login[1])
            {
                Console.Write(" wohoooo welcome to watsapp..." + namL[0]);
            }
            else
            {
                Console.Write("your num is not registred ,please register");

                Registration();
            }


            Console.WriteLine();
            Console.WriteLine("please enter \"1\"for add cotact,\"2\"for edit,and\"3\" for delete");

            string options = Console.ReadLine();
            Console.WriteLine(options);

            if (options == "1")
            {

                Console.Write("enter the num :");
                long phnumber = long.Parse(Console.ReadLine());
                Console.WriteLine("num: " + phnumber);

                Console.Write("enter the name :");
                string Cname = Console.ReadLine();
                Console.WriteLine("your contact is.." + Cname);
                Console.Write("contact added sucessfully...");

            }
            else if (options == "2")
            {
                Console.Write("enter the num :");
                long phnumber = long.Parse(Console.ReadLine());
                Console.WriteLine("num: " + phnumber);
                Console.Write("enter the name :");
                string Cname = Console.ReadLine();
                Console.WriteLine("your contact is.." + Cname);
                Console.Write("contact edited sucessfully");
            }
            else if (options == "3")
            {
                Console.Write("enter the name :");
                string Cname = Console.ReadLine();
                Console.WriteLine("your contact is.." + Cname);
                Console.Write("name deleted sucessfully");

            }
            else
            {
                Console.WriteLine("please enter the num between 1 to 3");
            }


        }


        //storing contact details

        List<long> CNU = new List<long>();
        List<string> CNA = new List<string>();











        public void Registration()//code for registration
        {
            Console.Write("enter the num :");
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine("num: " + number);
            login.Add(number);
            Console.Write("enter the name :");
            string name = Console.ReadLine();
            Console.WriteLine("your name is.." + name);
            namL.Add(name);
            Console.Write("welcome to watsapp..." + namL[1]);
            Console.WriteLine("please enter \"1\"for add,\"2\"for edit,and\"3\" for delete");
            string options = Console.ReadLine();
            Console.WriteLine(options);

            if (options == "1")
            {
                Console.Write("enter the num :");
                long phnumber = long.Parse(Console.ReadLine());
                Console.WriteLine("num: " + phnumber);
                CNU.Add(phnumber);
                Console.Write("enter the name :");
                string Cname = Console.ReadLine();
                Console.WriteLine("your contact is.." + Cname);
                Console.Write("contact added sucessfully...");

            }
            else if (options == "2")
            {
                Console.Write("enter the num :");
                long phnumber = long.Parse(Console.ReadLine());
                Console.WriteLine("num: " + phnumber);
                Console.Write("enter the name :");
                string Cname = Console.ReadLine();
                Console.WriteLine("your contact is.." + Cname);
                Console.Write("contact edited sucessfully");
            }
            else if (options == "3")
            {
                Console.Write("enter the name :");
                string Cname = Console.ReadLine();
                Console.WriteLine("your contact is.." + Cname);
                Console.Write("name deleted sucessfully");

            }
            else
            {
                Console.WriteLine("please enter the num between 1 to 3");
            }

        }

    }
    }


