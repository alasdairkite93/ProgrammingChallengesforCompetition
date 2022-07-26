using System;
using System.Linq;
using System.Collections.Generic;

namespace Iterations_and_lists
{
    class Program
    {
        static void Main(string[] args)
        {
                foreach (int i in Input(10, 1))
                {
                    //Console.WriteLine("{0}", i);
                }
        }
        public static System.Collections.Generic.IEnumerable<int> Input(int stat, int finish)
        {

            Console.WriteLine("Input start:");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input end:");
            int end = Convert.ToInt32(Console.ReadLine());

            List<int> Output = new List<int>();

            IEnumerable<int> results = Enumerable.Range(start, end).Select(x => x);

            foreach (int r in results)
            {
                //Console.WriteLine("\nr value:{0}", r);
                int result = r;

                while (result != 1)
                {
                    result = result % 2 == 0 ? result / 2 : (result * 3) + 1;
                    Output.Add(result);
                    yield return result;
                }
            }

            IEnumerable<int> distintOutput = Output.Distinct();


            Console.Clear();
            Console.WriteLine("{0}   {1}   {2}", start, end, distintOutput.Count());
        }
    }
}