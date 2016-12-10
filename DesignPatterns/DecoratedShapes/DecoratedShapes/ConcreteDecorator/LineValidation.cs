namespace DecoratedShapes.ConcreteDecorator
{
    using System;

    using DecoratedShapes.Decorator;

    public class LineValidation : Validation
    {
        protected override void Validate()
        {
            Console.WriteLine("Checking for Line valitions...");
        }
    }
}