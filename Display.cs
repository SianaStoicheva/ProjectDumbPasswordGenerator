using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Dumb_Password_Generator.View
{
    public class Display
    {

        List<int> numbers = new List<int>();


        public int ReadNumber(string message)
        {
            Console.Write(message + ": ");
            int number = int.Parse(Console.ReadLine());
            numbers.Add(number);
            return number;
        }


        public void OutputPrintPassword(string password)
        {
            Console.Write(password + " ");
        }
    }
}
