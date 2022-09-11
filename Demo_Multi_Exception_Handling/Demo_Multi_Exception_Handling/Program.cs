using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Multi_Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 6 };
            int[] arr2 = { 1, 0, 2, 3 };
            try
            {
                //Displaying Arrays

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                for (int i = 0; i < arr2.Length; i++)
                {
                    Console.WriteLine(arr2[i]/arr2[i+1]);
                }
                
            }

            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(" An Exception Has occured : {0},{1}", e.Message, e.StackTrace);
                // throw; 
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("An Exception has occured :{0}", e.Message);
            }

            finally
            {
                Console.WriteLine("Finally Blocks runs irrespective of Exception..!!");
                Console.WriteLine("array1");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("{0}", arr[i]);
                }

                Console.WriteLine("array2");
                for (int i = 0; i < arr2.Length; i++)
                {
                    Console.WriteLine(arr2[i]);
                }
            }
        }
    }
}
