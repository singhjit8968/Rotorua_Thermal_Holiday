using System;

namespace Rotorua_Thermal_Holiday
{
    class Program
    {   
        static void Main(string[] args)
        {
            //Using Colors to change text colors on Console.
            Console.ForegroundColor = ConsoleColor.Blue;
            
            //System Information message
            Console.WriteLine("\n\t\t\t\t\tWelcome to Rotorua Thermal Holiday");       
            Console.ForegroundColor = ConsoleColor.Cyan;
            
            //Module Information message
            Console.WriteLine("\n\tLogin System");                                      

            //creating variables to store information
            string username;
            string password1;
            string password2;
            //Variable used for holding loops
            int flag = 0;                                                             

            //using loop to get correct username
            while (flag == 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nEnter Username (Must be 8 characters or more): ");
                //Storing username
                username = Console.ReadLine();

                //checking if username is correct
                if (ValidUsername(username))        
                {
                    //exiting loop
                    flag = 1;                     
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    //telling user username criteria does not match
                    Console.WriteLine("\nInvalid Username. Username must be 8 characters or more.");        
                }
            }

            flag = 0;       //resetting variable to use again
            
            //while loop to get correct passwords.
            while(flag == 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nEnter Password (Must be 8 characters or more): ");
                //storing first password
                password1 = Console.ReadLine();                                             

                Console.WriteLine("\nRepeat Password (Must same as earlier password): ");
                //storing second password
                password2 = Console.ReadLine();

                //checking if password's criteria matches.
                if (ValidPasswords(password1, password2))               
                {
                    //exiting loop
                    flag = 1;                                           
                } else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    //showing password criteria does not match.
                    Console.WriteLine("\n Password criteria does not match. Try Again.");   
                }

            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            //showing everything worked fine.
            Console.WriteLine("\n\t\t Username and Password have been accepted and set.");

            //holding output
            Console.Read();                                     
        }
        
        /// <summary>
        /// Used to check if username is valid
        /// </summary>
        /// <param name="username"> string param for username</param>
        /// <returns>true or false if username is valid.</returns>
        static bool ValidUsername(string username)
        {
            //if length of string is more than or equals to 8
            if (username.Length >= 8)        
            {
                //returning true
                return true;               
            }
            // else returning false.
            return false;                  
        }

        /// <summary>
        /// Used to check if passwords are valid
        /// </summary>
        /// <param name="password1"> First password in string</param>
        /// <param name="password2"> Second Password in string</param>
        /// <returns>whether the passwords criteria matches</returns>
        static bool ValidPasswords(string password1, string password2)
        {
            //checking if length of passwords are more than 8 characters and passwords are same.
            if (password1.Length >= 8 && password1 == password2)     
            {
                //returning true
                return true;                       
            }
            // else returning false.
            return false;                          
        }
    }
}
