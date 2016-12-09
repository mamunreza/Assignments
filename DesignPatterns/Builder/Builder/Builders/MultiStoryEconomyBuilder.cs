namespace Builder.Builders
{
    using Builder.BuilderContracts;

    public class MultiStoryEconomyBuilder : IMultiStoryBuilder
    {
        private Building building;

        public MultiStoryEconomyBuilder()
        {
            this.building = new Building("Multi Story Economy House");
        }

        public void BuildWalls()
        {
            this.building.WallType = WallTypeCodes.BrickWall;
        }

        public void BuildFloors()
        {
            this.building.FloorType = FloorTypeCodes.HardwoodFlooring;
        }

        public void BuildDoors()
        {
            this.building.DoorType = DoorTypeCodes.WoodenDoor;
        }

        public void BuildWindows()
        {
            this.building.WindowType = WindowTypeCodes.AwningWindow;
        }

        public void BuildRooms()
        {
            this.building.RoomType = RoomTypeCodes.Medium;
        }

        public Building Building
        {
            get
            {
                return this.building;
            }
        }

        public void BuildDecorations()
        {
            this.building.DecorationType = DecorationTypeCodes.Normal;
        }

        public void BuildMultiStory(int count)
        {
            this.building.StoryType = StoryTypeCodes.Multiple;
        }
    }
}