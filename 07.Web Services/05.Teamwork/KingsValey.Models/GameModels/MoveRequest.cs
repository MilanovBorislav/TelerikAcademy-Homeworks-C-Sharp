namespace KingsValey.Models.GameModels
{
    public class MoveRequest
    {
        public int GameId { get; set; }

        public int PlayerId { get; set; }

        public int LocationX { get; set; }

        public int LocationY { get; set; }

        public int DestinationX { get; set; }

        public int DestinationY { get; set; }

        public string SessionKey { get; set; }
    }
}