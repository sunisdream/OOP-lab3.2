using System;
using System.IO;

namespace OOP_lab_3_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("input.txt");

            string str = file.ReadToEnd();

            if (Char.IsDigit(str[0]) && Char.IsDigit(str[2]))
            {
                if ((str[2] - '0') % 2 == 0)
                {
                    Console.WriteLine("Першi 2 символи є парним числом!");
                    
                    return;
                }

                Console.WriteLine("Першi 2 символи не є парним числом!");

                return;
            }

            Console.WriteLine("Першi 2 символи не є числом!");

            return;
        }
    }
}
