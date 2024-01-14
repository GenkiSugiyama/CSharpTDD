using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Add2(int a, int b, int c) 
        {
            return a+ b + c;
        }

        public static int Add3(int a, int b)
        {
            if (a == 0)
            {
                return 0;
            }
            return a + b;
        }
    }
}
