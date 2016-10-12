namespace TemplateMethodSort
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class MergeSort : AbstractSort
    {
        public MergeSort(List<int> list, int left, int right)
            : base(list, left, right)
        {
        }

        public override int Divide(List<int> list, int left, int right)
        {
            //return start = (left + right) / 2;
            return 0;
        }

        public override void Conquer(List<int> list, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                Conquer(list, left, middle);
                Conquer(list, middle + 1, right);

                Combine(list, left, middle, right);
            }
        }

        public override void Combine(List<int> list, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(list.ToArray(), left, leftArray, 0, middle - left + 1);
            Array.Copy(list.ToArray(), middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    list[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    list[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    list[k] = leftArray[i];
                    i++;
                }
                else
                {
                    list[k] = rightArray[j];
                    j++;
                }
            }
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