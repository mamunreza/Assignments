namespace DecoratedShapes.ConcreteComponent
{
    using System;

    using DecoratedShapes.Component;

    public class Point : GeometricSahpe
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Point\n");
        }
    }
}