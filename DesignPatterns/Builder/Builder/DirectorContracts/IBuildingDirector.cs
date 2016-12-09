namespace Builder.DirectorContracts
{
    using Builder.BuilderContracts;

    public interface IBuildingDirector
    {
        void Construct(IBuildingBuilder buildingBuilder);
    }
}