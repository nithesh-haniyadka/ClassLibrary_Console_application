using System;
using System.Windows.Forms;

namespace ClassLibrary_test
{
    public class Demo
    {
        int i;
        public int sum(int a, int b)
        {
            i = a + b;
            return i;
        }

        public void Display()
        {
            Console.WriteLine("I am great");
        }

    }
}