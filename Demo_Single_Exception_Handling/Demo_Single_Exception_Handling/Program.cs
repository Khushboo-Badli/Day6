using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Single_Exception_Handling
{
    class Program : System.Exception
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single Exception Handling");
            try
            {
                int[] arr = { 1, 2, 3, 4, 5, 6, };
                //Displaying Array
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                Console.WriteLine(arr[10]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("An Exception has Occured : {0} ,{1} ", e.Message , e.StackTrace);
            }
        }
    }
}
