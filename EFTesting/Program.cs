﻿using System;

namespace EFTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            int result = -1;
            while (result != 9)
            {
                result = MainMenu();
            }
        }

        static int MainMenu()
        {
            int result = -1;
            ConsoleKeyInfo cki;
            bool cont = false;
            do
            {
                Console.Clear();
                WriteHeader("Welcome to Newbie Data Systems");
                WriteHeader("Main Menu");
                Console.WriteLine("\r\nPlease select from the list below for what you would like to do today:");
                Console.WriteLine("1. List all machines in Inventory");
                Console.WriteLine("2. List All Operating Systems");
                Console.WriteLine("3 Data Entry Menu");
                Console.WriteLine("9. Exit");
                cki = Console.ReadKey();
                try
                {
                    result = Convert.ToInt16(cki.KeyChar.ToString());
                    if (result == 1)
                    {
                        //DisplayALlMachines();
                    }
                    else if(result == 2) 
                    {
                        //DisplayOperatingSystems();
                    }
                    else if(result == 3)
                    {
                        DataEntryMenu();
                    }
                    else if(result == 9) 
                    {
                        //We are exiting so nothing to do.
                        cont = true;
                    }
                }
                catch (System.FormatException fe)
                {
                    //A key that wasn't a number.
                    Console.WriteLine(fe);
                }
            } while (!cont);
            return result;
        }

        static void DataEntryMenu()
        {
            ConsoleKeyInfo _consoleKeyInfo;
            int result = -1;
            bool cont = false;
            do
            {
                
            } while (true);
        }
    }
}
