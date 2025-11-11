using System;
using Dumb_Password_Generator.Controller;

namespace DumbPasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StupidPasswordController controller = new StupidPasswordController();
            controller.Run();
        }
    }
}
