using System;
using System.Threading.Tasks;

namespace N_5
{
    class Program
    {
        static void F(int x, ParallelLoopState pls)
        {
            if(x == 61)
                pls.Break();

            Console.WriteLine( x );
        }

        static void Main(string[] args)
        {
            ParallelLoopResult result = Parallel.ForEach<int>(new int[] {1,4,61,85}, F);
        }
    }
}