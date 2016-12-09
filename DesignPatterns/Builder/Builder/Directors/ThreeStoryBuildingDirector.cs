namespace Builder.Directors
{
    using Builder.BuilderContracts;
    using Builder.DirectorContracts;

    public class ThreeStoryBuildingDirector : IMultiStoryBuildingDirector
    {
        public void Construct(IMultiStoryBuilder buildingBuilder)
        {
            buildingBuilder.BuildWalls();
            buildingBuilder.BuildFloors();
            buildingBuilder.BuildDoors();
            buildingBuilder.BuildWindows();
            buildingBuilder.BuildRooms();
            buildingBuilder.BuildDecorations();
            buildingBuilder.BuildMultiStory(3);
        }
    }
}