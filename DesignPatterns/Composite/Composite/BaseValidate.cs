namespace Composite
{
    using System;

    /// <summary>
    /// The base validate. (Component)
    /// </summary>
    public abstract class BaseValidate
    {
        public BaseValidate(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }

        public virtual void Validate()
        {
            Console.WriteLine("Validating the control: " + this.Name);
        }
    }
}