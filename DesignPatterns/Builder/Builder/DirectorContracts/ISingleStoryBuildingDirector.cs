namespace Builder.DirectorContracts
{
    using Builder.BuilderContracts;

    public interface ISingleStoryBuildingDirector
    {
        void Construct(ISingleStoryBuilder buildingBuilder);
    }
}