namespace Builder.Builders
{
    using Builder.BuilderContracts;

    public class SingleStoryBrickBuilder : ISingleStoryBuilder
    {
        private Building building;

        public SingleStoryBrickBuilder()
        {
            this.building = new Building("Single Story Brick House");
        }

        public void BuildWalls()
        {
            this.building.WallType = WallTypeCodes.BrickWall;
        }

        public void BuildFloors()
        {
            this.building.FloorType = FloorTypeCodes.CeramicTile;
        }

        public void BuildDoors()
        {
            this.building.DoorType = DoorTypeCodes.WoodenDoor;
        }

        public void BuildWindows()
        {
            this.building.WindowType = WindowTypeCodes.SliderWindow;
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
    }
}