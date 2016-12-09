namespace Builder.Builders
{
    using Builder.BuilderContracts;

    public class SingleStoryGlassBuilder : ISingleStoryBuilder
    {
        private Building building;

        public SingleStoryGlassBuilder()
        {
            this.building = new Building("Single Story Glass House");
        }

        public void BuildWalls()
        {
            this.building.WallType = WallTypeCodes.GlassWall;
        }

        public void BuildFloors()
        {
            this.building.FloorType = FloorTypeCodes.LaminateFlooring;
        }

        public void BuildDoors()
        {
            this.building.DoorType = DoorTypeCodes.GlassDoor;
        }

        public void BuildWindows()
        {
            this.building.WindowType = WindowTypeCodes.PictureWindow;
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