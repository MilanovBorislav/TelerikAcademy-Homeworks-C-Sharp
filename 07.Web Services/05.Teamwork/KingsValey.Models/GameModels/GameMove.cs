using System;
using System.Collections.Generic;
using System.Linq;

namespace KingsValey.Models.GameModels
{
    public class GameMove
    {
        private const byte GAMEFIELD_SIZE = 5;

        private const byte MIDDLE_ROW = 2;
        private const byte MIDDLE_COL = 2;

        private bool[,] gameBoard;

        private ICollection<GameFigure> figures;

        public GameMove(ICollection<GameFigure> figures)
        {
            this.gameBoard = new bool[GAMEFIELD_SIZE, GAMEFIELD_SIZE];
            this.figures = figures;

            PopulateBoard();
        }

        public ICollection<Position> GetAvailableDestinations(int x, int y)
        {
            HashSet<Position> availableDestinations = new HashSet<Position>();

            int row = y;
            int col = x;

            // UP
            while (row > 0 && !gameBoard[row - 1, col])
            {
                row--;
            }

            if (row != y)
            {
                availableDestinations.Add(new Position { X = col, Y = row });
            }

            row = y;

            // DOWN
            while (row < GAMEFIELD_SIZE - 1 && !gameBoard[row + 1, col])
            {
                row++;
            }

            if (row != y)
            {
                availableDestinations.Add(new Position { X = col, Y = row });
            }

            row = y;

            // LEFT
            while (col > 0 && !gameBoard[row, col - 1])
            {
                col--;
            }

            if (col != x)
            {
                availableDestinations.Add(new Position { X = col, Y = row });
            }

            col = x;

            // RIGHT
            while (col < GAMEFIELD_SIZE - 1 && !gameBoard[row, col + 1])
            {
                col++;
            }

            if (col != x)
            {
                availableDestinations.Add(new Position { X = col, Y = row });
            }

            col = x;

            // TOP LEFT
            while (row > 0 && col > 0 && !gameBoard[row - 1, col - 1])
            {
                row--;
                col--;
            }

            if (row != y && col != x)
            {
                availableDestinations.Add(new Position { X = col, Y = row });
            }

            row = y;
            col = x;

            // TOP RIGHT
            while (row > 0 && col < GAMEFIELD_SIZE - 1 && !gameBoard[row - 1, col + 1])
            {
                row--;
                col++;
            }

            if (row != y && col != x)
            {
                availableDestinations.Add(new Position { X = col, Y = row });
            }

            row = y;
            col = x;

            // DOWN LEFT
            while (row < GAMEFIELD_SIZE - 1 && col > 0 && !gameBoard[row + 1, col - 1])
            {
                row++;
                col--;
            }

            if (row != y && col != x)
            {
                availableDestinations.Add(new Position { X = col, Y = row });
            }

            row = y;
            col = x;

            // DOWN RIGHT
            while (row < GAMEFIELD_SIZE - 1 && col < GAMEFIELD_SIZE - 1 && !gameBoard[row + 1, col + 1])
            {
                row++;
                col++;
            }

            if (row != y && col != x)
            {
                availableDestinations.Add(new Position { X = col, Y = row });
            }

            return availableDestinations;
        }

        private void PopulateBoard()
        {
            foreach (var figure in figures)
            {
                this.gameBoard[figure.Y, figure.X] = true;
            }
        }

        public bool IsGameEnded()
        {
            return figures.Any(f => f.X == MIDDLE_COL && f.Y == MIDDLE_COL && f.IsKing);
        }

        public Color WinnerColor()
        {
            var figure = figures.FirstOrDefault(f => f.X == MIDDLE_COL && f.Y == MIDDLE_ROW && f.IsKing);

            if (figure == null)
            {
                throw new InvalidOperationException("There is no winner yet!");
            }

            return figure.color;
        }
    }
}