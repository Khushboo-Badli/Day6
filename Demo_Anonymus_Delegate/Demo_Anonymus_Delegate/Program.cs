using System;

namespace Demo_Anonymus_Delegate
{
    public delegate int Mydelegate(int x, int y); // we can also use void return type 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymus Function!");
            Mydelegate del1 = delegate (int x , int y)
            {
                Console.WriteLine("del1 - addition");
                Console.WriteLine(x + y );
                return 0;
            };
            Mydelegate del2 = delegate (int x, int y) 
            {
                Console.WriteLine( "del2 - subtraction");
                Console.WriteLine(x - y);
                return 0;
            };
            Mydelegate del3 = delegate (int x, int y)
            {
                Console.WriteLine("del3 - multiplication");
                Console.WriteLine(x * y);
                return 0;
            };
            Mydelegate del4 = del1 + del2;

            //calling delegate
            del3(2,3); //singlecasting delegate
            del4(3,4); //multicasting delegate
           
        }
    }
}
