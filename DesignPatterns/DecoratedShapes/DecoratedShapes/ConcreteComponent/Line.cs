namespace DecoratedShapes.ConcreteComponent
{
    using System;

    using DecoratedShapes.Component;

    public class Line : GeometricSahpe
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Line\n");
        }
    }
}