using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp38
{
   
    public class Forgetpassword : User
    {

        public Forgetpassword(string userName, string password) : base(userName, password)

        {
            Console.WriteLine("PLS ENTER USERNAME AND PASSWORD");

            string usernameenter = Console.ReadLine();
            string passwordenter = Console.ReadLine();

            if (userName == usernameenter && password == passwordenter)
            {
                Console.WriteLine("succesfully logged in");
            }
            else if (userName != usernameenter && password != passwordenter)
            {
                Console.Clear();

            }
        }



            public class Forgetpassword2 : User2
        {

            public Forgetpassword2(string userName, string password) : base(userName, password)
            {


                Console.WriteLine("your password or username is not correct,pls enter new one");
                Console.WriteLine("pls enter username");
                string usernameenter2 = Console.ReadLine();
                Console.WriteLine("pls enter password");
                string passwordenter2 = Console.ReadLine();


                if (userName == usernameenter2 && password == passwordenter2)
                {
                    Console.WriteLine(" succesfully logged in2");
                }
                else
                {
                    Console.WriteLine("wrong username or password.you will not enter new one");
                }
            }
         }
     } 
 }
 
 

