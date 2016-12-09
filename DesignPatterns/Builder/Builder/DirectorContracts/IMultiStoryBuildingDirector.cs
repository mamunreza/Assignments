namespace Builder.DirectorContracts
{
    using Builder.BuilderContracts;

    public interface IMultiStoryBuildingDirector
    {
        void Construct(IMultiStoryBuilder buildingBuilder);
    }
}