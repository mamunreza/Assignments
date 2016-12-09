namespace Builder.BuilderContracts
{
    public interface IBuildingBuilder
    {
        void BuildWalls();
        void BuildFloors();
        void BuildDoors();
        void BuildWindows();
        void BuildRooms();
        Building Building { get; }
    }
}