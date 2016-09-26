using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = DefinedList(15);
            Console.WriteLine("Quick Sort");
            Console.WriteLine("====================================================================");
            List<int> qList = RandomList(18, 5);
            var qSort = new QuickSort(qList, 0, qList.Count);
            qSort.TemplateMethod();
            Console.WriteLine();


            Console.WriteLine("Merge Sort");
            Console.WriteLine("====================================================================");
            List<int> mList = RandomList(18, 3);
            var mSort = new MergeSort(mList, 0, mList.Count - 1);
            mSort.TemplateMethod();
            Console.WriteLine();

            Console.ReadKey();
        }

        static List<int> RandomList(int size, int seed)
        {
            List<int> ret = new List<int>(size);
            Random rand = new Random(seed);
            for (int i = 0; i < size; i++)
            {
                ret.Add(rand.Next(rand.Next(100)));
            }
            return ret;
        }

        static List<int> DefinedList()
        {
            List<int> ret = new List<int>
                                {
                                    3, 1, 61, 5, 4, 1, 87, 43, 33, 45, 43, 11, 20, 8, 2, 98, 90, 16
                                };
            return ret;
        }
    }
}
