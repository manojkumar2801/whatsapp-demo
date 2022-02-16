using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whatsapp_demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Client C1 = new Client();
            Server s = new Server();
            Client C2 = new Client();



            Console.WriteLine(" select one option login or register");//asking user to select login or register
            string abc = Console.ReadLine();
            if (abc == "login")
            {
                C1.Login();
            }
            else if (abc == "register")
            {
                C1.Registration();

            }
            else
            {
                Console.WriteLine("please select \"Login\" or \"register\" ");
            }
            Console.WriteLine("please enter \"1\"to create grp or press \"2\" to continue");//asking user to create grp
            string num2 = Console.ReadLine();

            if (num2 == "1")
            {
                s.Cnt_list();
                s.addmemgrp();



            }
            else
            {
                Console.WriteLine("thankyou");
            }
            Console.Read();
            Console.WriteLine("send msg to client");//asking user to send msg to server



            s.Sendc1();
            s.sendc2();
            // displaying the chat historey
            s.dplay();


            Console.WriteLine(" displaying all the group members you ware added");


            Console.Read();
        }

    }

        }
    


