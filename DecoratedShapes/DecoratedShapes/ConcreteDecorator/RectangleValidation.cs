namespace DecoratedShapes.ConcreteDecorator
{
    using System;

    using DecoratedShapes.Decorator;

    public class RectangleValidation : Validation
    {
        protected override void Validate()
        {
            Console.WriteLine("Checking for Rectangle valitions...");
        }
    }
}