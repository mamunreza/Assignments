namespace DecoratedShapes.ConcreteDecorator
{
    using System;

    using DecoratedShapes.Component;
    using DecoratedShapes.Decorator;

    public class PointValidation : Validation
    {
        protected override void Validate()
        {
            Console.WriteLine("Checking for Point valitions...");
        }
    }
}