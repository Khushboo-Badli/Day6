using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegates
{
    class MyProgram
    {
        public delegate void delmethod(); //declaring delmethod
        class Program
        {
            public static void displays()
            {
                Console.WriteLine("Inside Display()");
            }

            public static void show()
            {
                Console.WriteLine("Inside show()");
            }

            public void print()
            {
                Console.WriteLine("Inside Print()");
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Single  casting delegate");
                // assigning static method show() to delegate delmethod
                delmethod del1 = Program.show;
                delmethod del2 = Program.displays; //another method to assigning static method show() to delegate delmethod

                Program obj1 = new Program(); //creating object of a class for refferring non- static 
                delmethod del3 = obj1.print;

                del1();
                del2();
                del3();
            }
        }
    }
    
    
}
