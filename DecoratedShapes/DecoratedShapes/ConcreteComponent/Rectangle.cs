namespace DecoratedShapes.ConcreteComponent
{
    using System;

    using DecoratedShapes.Component;

    public class Rectangle : GeometricSahpe
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle\n");
        }
    }
}