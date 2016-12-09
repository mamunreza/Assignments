namespace Builder
{
    public class Building
    {
        private string houseName;

        public WallTypeCodes WallType { get; set; }

        public DoorTypeCodes DoorType { get; set; }

        public WindowTypeCodes WindowType { get; set; }

        public FloorTypeCodes FloorType { get; set; }

        public RoomTypeCodes RoomType { get; set; }

        public DecorationTypeCodes DecorationType { get; set; }

        public StoryTypeCodes StoryType { get; set; }

        public Building(string houseName)
        {
            this.houseName = houseName;
        }
        
        public override string ToString()
        {
            return string.Format("Name: {0}\nWall: {1}\nDoor: {2}\nWindow: {3}\nFloor: {4}\nRoom: {5}\nDecoration: {6}\nStory: {7}", this.houseName, this.WallType, this.DoorType, this.WindowType, this.FloorType, this.RoomType, this.DecorationType, this.StoryType);
        }
    }
}