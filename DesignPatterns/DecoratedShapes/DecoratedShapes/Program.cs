using System;

namespace DecoratedShapes
{
    using DecoratedShapes.ConcreteComponent;
    using DecoratedShapes.ConcreteDecorator;

    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point();
            var line = new Line();
            var rectangle = new Rectangle();

            var pointDecorator = new PointValidation();
            var lineDecorator = new LineValidation();
            var rectangleDecorator = new RectangleValidation();

            pointDecorator.SetShape(point);
            pointDecorator.Draw();

            pointDecorator.SetShape(line);
            lineDecorator.SetShape(pointDecorator);
            lineDecorator.Draw();

            pointDecorator.SetShape(rectangle);
            lineDecorator.SetShape(pointDecorator);
            rectangleDecorator.SetShape(lineDecorator);
            rectangleDecorator.Draw();

            Console.ReadKey();
        }
    }
}
