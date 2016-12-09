namespace Builder.Directors
{
    using Builder.BuilderContracts;
    using Builder.DirectorContracts;

    public class SingleStoryBuildingDirector : ISingleStoryBuildingDirector
    {
        public void Construct(ISingleStoryBuilder buildingBuilder)
        {
            buildingBuilder.BuildWalls();
            buildingBuilder.BuildFloors();
            buildingBuilder.BuildDoors();
            buildingBuilder.BuildWindows();
            buildingBuilder.BuildRooms();
            buildingBuilder.BuildDecorations();
        }
    }
}