namespace DecoratedShapes.Decorator
{
    using DecoratedShapes.Component;

    public abstract class Validation : GeometricSahpe
    {
        protected GeometricSahpe geopGeometricSahpe;

        public void SetShape(GeometricSahpe geometricSahpe)
        {
            this.geopGeometricSahpe = geometricSahpe;
        }

        public override void Draw()
        {
            this.Validate();
            this.geopGeometricSahpe.Draw();
        }

        protected abstract void Validate();
    }
}