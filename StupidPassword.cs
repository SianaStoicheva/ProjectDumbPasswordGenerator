using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Dumb_Password_Generator.View;

namespace Dumb_Password_Generator.Model
{
    public class StupidPassword
    {

        private int n;
        private int l;
        public int N
        {
            get
            {
                return n;
            }
            set
            {
                n = value;
            }
        }
        public int L
        {
            get
            {
                return l;
            }
            set
            {
                l = value;
            }
        }
        public StupidPassword() : this(0, 0) { }
        public StupidPassword(int n, int l)
        {
            N = n;
            L = l;
        }
    }
}
