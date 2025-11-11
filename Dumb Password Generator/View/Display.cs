using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dumb_Password_Generator.View
{
    public class Display
    {
        public int ReadNumber(string message)
        {
            int number = 0;
            bool isValid = false;

            while (!isValid)
            {
                Console.Write(message + ": ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out number))
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Моля, въведи цяло число!");
                }
            }

            return number;
        }

        public void PrintPassword(string password)
        {
            Console.Write(password + " ");
        }
    }
}
