namespace TemplateMethodSort
{
    using System.Collections;
    using System.Collections.Generic;

    public abstract class AbstractSort
    {
        private List<int> list;
        private List<int> mainList = new List<int>();

        private int left;

        private int right;

        public int start;

        protected AbstractSort(List<int> list, int left, int right)
        {
            this.list = list;
            this.left = left;
            this.right = right;

            foreach (var item in list)
            {
                mainList.Add(item);
            }
        }

        public abstract int Divide(List<int> list, int left, int right);
        public abstract void Conquer(List<int> list, int left, int right);
        public abstract void Combine(List<int> list, int left, int middle, int right);
        public abstract void Compare(List<int> list, List<int> mainList);
        
        public void TemplateMethod()
        {
            Divide(this.list, left, right);
            Conquer(this.list, left, right);
            Combine(this.list, left, start, right);
            Compare(this.list, this.mainList);
        }
    }
}