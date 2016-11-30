namespace Composite
{
    using System.Collections.Generic;

    /// <summary>
    /// The composit validate. (Composit)
    /// </summary>
    public class CompositValidate : BaseValidate
    {
        public CompositValidate(string name)
            : base(name)
        {
        }

        private List<BaseValidate> leaves = new List<BaseValidate>();

        public void Add(BaseValidate component)
        {
            this.leaves.Add(component);
        }

        public void Remove(BaseValidate component)
        {
            this.leaves.Remove(component);
        }

        public override void Validate()
        {
            foreach (BaseValidate leaf in this.leaves)
            {
                leaf.Validate();
            }
        }
    }
}