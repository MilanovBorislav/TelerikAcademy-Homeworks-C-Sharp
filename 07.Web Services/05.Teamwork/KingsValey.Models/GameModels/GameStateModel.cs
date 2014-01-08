namespace KingsValey.Models.GameModels
{
    public class GameStateModel
    {
        public int GameStateModelId { get; set; }

        public int PlayerInMove { get; set; }

        public int WhitePlayer { get; set; }

        public int RedPlayer { get; set; }

        public string GameFigures { get; set; }
    }
}