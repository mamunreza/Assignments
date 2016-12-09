namespace Builder.Builders
{
    using Builder.BuilderContracts;

    public class MultiStoryLuxuriousBuilder : IMultiStoryBuilder
    {
        private Building building;

        public MultiStoryLuxuriousBuilder()
        {
            this.building = new Building("Multi Story Luxurious House");
        }

        public void BuildWalls()
        {
            this.building.WallType = WallTypeCodes.CastStoneMantelsWall;
        }

        public void BuildFloors()
        {
            this.building.FloorType = FloorTypeCodes.MarbleTiles;
        }

        public void BuildDoors()
        {
            this.building.DoorType = DoorTypeCodes.WoodenDoor;
        }

        public void BuildWindows()
        {
            this.building.WindowType = WindowTypeCodes.CasementWindow;
        }

        public void BuildRooms()
        {
            this.building.RoomType = RoomTypeCodes.Big;
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
            this.building.DecorationType = DecorationTypeCodes.Luxurious;
        }

        public void BuildMultiStory(int count)
        {
            this.building.StoryType = StoryTypeCodes.Multiple;
        }
    }
}