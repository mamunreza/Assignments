using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            lineDecorator.SetShape(line);
            lineDecorator.Draw();

            rectangleDecorator.SetShape(rectangle);
            rectangleDecorator.Draw();

            Console.ReadKey();
        }
    }
}
