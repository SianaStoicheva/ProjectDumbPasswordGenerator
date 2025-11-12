using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dumb_Password_Generator.Model;
using Dumb_Password_Generator.View;

namespace Dumb_Password_Generator.Controller
{
    public class StupidPasswordController
    {
        private StupidPassword model;
        private Display display;

        public StupidPasswordController()
        {
            display = new Display();
            model = new StupidPassword();
        }
        public void Run()
        {
            int n = display.ReadNumber("Enter N ");
            int l = display.ReadNumber("Enter L ");
            StupidPassword model = new StupidPassword(n,l);
            GeneratePassword();

        }
        private void GeneratePassword()
        {
            int n = model.N;
            int l = model.L;
            for (int a = 1; a <= n; a++)
            {
                for (int b = 1; b <= n; b++)
                {
                    for (char c = 'a'; c < 'a' + l; c++)
                    {
                        for (char d = 'a'; d < 'a' + l; d++)
                        {
                            for (int e = 1; e <= n; e++)
                            {
                                if (e > a && e > b)
                                {
                                    string password = $"{a}{b}{c}{d}{e}";
                                    display.OutputPrintPassword(password);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
