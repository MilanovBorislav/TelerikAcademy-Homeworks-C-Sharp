namespace KingsValey.Models.GameModels
{
    public class GameFigure
    {
        public int X { get; set; }

        public int Y { get; set; }

        public bool IsKing { get; set; }

        public Color color { get; set; }

        public void MoveTo(byte x, byte y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}