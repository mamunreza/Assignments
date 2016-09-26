namespace TemplateMethodSort
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class QuickSort : AbstractSort
    {
        public QuickSort(List<int> list, int left, int right)
            : base(list, left, right)
        {
            
        }

        public override int Divide(List<int> list, int left, int right)
        {
            int start = left;
            int pivot = list[start];
            left++;
            right--;

            while (true)
            {
                while (left <= right && list[left] <= pivot)
                    left++;

                while (left <= right && list[right] > pivot)
                    right--;

                if (left > right)
                {
                    list[start] = list[left - 1];
                    list[left - 1] = pivot;

                    return left;
                }

                int temp = list[left];
                list[left] = list[right];
                list[right] = temp;
            }
        }

        public override void Conquer(List<int> list, int left, int right)
        {
            if (list == null || list.Count <= 1)
                return;

            if (left < right)
            {
                int pivotIdx = Divide(list, left, right);
                Conquer(list, left, pivotIdx - 1);
                Conquer(list, pivotIdx, right);
            }
        }

        public override void Combine(List<int> list, int left, int middle, int right)
        {
            ;
        }

        public override void Compare(List<int> list, List<int> mainList)
        {
            Console.WriteLine("Original values:");
            mainList.ForEach(delegate (int val)
            {
                Console.Write(val);
                Console.Write(", ");
            });
            Console.WriteLine();

            Console.WriteLine("Sorted values:");
            list.ForEach(delegate (int val)
            {
                Console.Write(val);
                Console.Write(", ");
            });
            Console.WriteLine();
        }
    }
}