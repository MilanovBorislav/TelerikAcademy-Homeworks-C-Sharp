using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Mines
{
    public class Mines
    {
        public class Scores
        {
            string name;
            int score;

            public string playerName
            {
                get { return name; }
                set { name = value; }
            }

            public int Score
            {
                get { return score; }
                set { score = value; }
            }

            public Scores() { }

            public Scores(string име, int то4ки)
            {
                this.name = име;
                this.score = то4ки;
            }
        }

        static void Main(string[] arguments)
        {
            string command = string.Empty;
            char[,] gameField = CreateGameField();
            char[,] bombs = PutBumbs();
            int counter = 0;
            bool thunder = false;
            List<Scores> champions = new List<Scores>(6);
            int row = 0;
            int col = 0;
            bool firstFlag = true;
            const int max = 35;
            bool secondFlag = false;

            do
            {
                if (firstFlag)
                {
                    Console.WriteLine("Let's play \"Mines\". Try your luck.Find mines." +
                    "\nCommand 'top' shows rating, \nCommand 'restart' start new game, \nCommand 'exit' exit of  the game.");
                    Dump(gameField);
                    firstFlag = false;
                }
                Console.Write("Write row and col : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row <= gameField.GetLength(0) && col <= gameField.GetLength(1))
                    {
                        command = "turn";
                    }
                }
                switch (command)
                {
                    case "top":
                        rating(champions);
                        break;
                    case "restart":
                        gameField = CreateGameField();
                        bombs = PutBumbs();
                        Dump(gameField);
                        thunder = false;
                        firstFlag = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, Bye!");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                tisinahod(gameField, bombs, row, col);
                                counter++;
                            }
                            if (max == counter)
                            {
                                secondFlag = true;
                            }
                            else
                            {
                                Dump(gameField);
                            }
                        }
                        else
                        {
                            thunder = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nError! Invalid Command\n");
                        break;
                }
                if (thunder)
                {
                    Dump(bombs);
                    Console.Write("\nEnd! Died heroically with {0} score. " +
                        "Give your nickname: ", counter);
                    string nickname = Console.ReadLine();
                    Scores playerScores = new Scores(nickname, counter);
                    if (champions.Count < 5)
                    {
                        champions.Add(playerScores);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Score < playerScores.Score)
                            {
                                champions.Insert(i, playerScores);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }
                    champions.Sort((Scores firstScores, Scores secondScores) => secondScores.playerName.CompareTo(firstScores.playerName));
                    champions.Sort((Scores firstScores, Scores secondScores) => secondScores.Score.CompareTo(firstScores.Score));
                    rating(champions);

                    gameField = CreateGameField();
                    bombs = PutBumbs();
                    counter = 0;
                    thunder = false;
                    firstFlag = true;
                }
                if (secondFlag)
                {
                    Console.WriteLine("\nCongratulation! Open 35 cells without a drop of blood.");
                    Dump(bombs);
                    Console.WriteLine("Give your name: ");
                    string playerName = Console.ReadLine();
                    Scores playerScores = new Scores(playerName, counter);
                    champions.Add(playerScores);
                    rating(champions);
                    gameField = CreateGameField();
                    bombs = PutBumbs();
                    counter = 0;
                    secondFlag = false;
                    firstFlag = true;
                }
            }

            while (command != "exit");

            Console.WriteLine("Made in Bulgaria");
            Console.WriteLine("Bye, Bye!");
            Console.Read();

        }

        private static void rating(List<Scores> scores)
        {
            Console.WriteLine("\nScores:");
            if (scores.Count > 0)
            {
                for (int i = 0; i < scores.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii",
                        i + 1, scores[i].playerName, scores[i].Score);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty rating!\n");
            }
        }

        private static void tisinahod(char[,] gameField,
            char[,] bombs, int row, int col)
        {
            char numberOfBombs = CommonCount(bombs, row, col);
            bombs[row, col] = numberOfBombs;
            gameField[row, col] = numberOfBombs;
        }

        private static void Dump(char[,] board)
        {
            int rowLength = board.GetLength(0);
            int colLength = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int row = 0; row < rowLength; row++)
            {
                Console.Write("{0} | ", row);
                for (int col = 0; col < colLength; col++)
                {
                    Console.Write(string.Format("{0} ", board[row, col]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameField()
        {
            int fieldRows = 5;
            int fieldCols = 10;
            char[,] gameField = new char[fieldRows, fieldCols];
            for (int row = 0; row < fieldRows; row++)
            {
                for (int col = 0; col < fieldCols; col++)
                {
                    gameField[row, col] = '?';
                }
            }

            return gameField;
        }

        private static char[,] PutBumbs()
        {
            int rowLength = 5;
            int colLength = 10;
            char[,] gameField = new char[rowLength, colLength];

            for (int row = 0; row < rowLength; row++)
            {
                for (int col = 0; col < colLength; col++)
                {
                    gameField[row, col] = '-';
                }
            }

            List<int> randomNumbersList = new List<int>();
            while (randomNumbersList.Count < 15)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);
                if (!randomNumbersList.Contains(randomNumber))
                {
                    randomNumbersList.Add(randomNumber);
                }
            }

            foreach (int number in randomNumbersList)
            {
                int col = (number / colLength);
                int row = (number % colLength);
                if (row == 0 && number != 0)
                {
                    col--;
                    row = colLength;
                }
                else
                {
                    row++;
                }
                gameField[col, row - 1] = '*';
            }

            return gameField;
        }

        private static void Calculations(char[,] field)
        {
            int colLength = field.GetLength(0);
            int rowLength = field.GetLength(1);

            for (int col = 0; col < colLength; col++)
            {
                for (int row = 0; row < rowLength; row++)
                {
                    if (field[col, row] != '*')
                    {
                        char count = CommonCount(field, col, row);
                        field[col, row] = count;
                    }
                }
            }
        }

        private static char CommonCount(char[,] charArr, int row, int col)
        {
            int count = 0;
            int rowLength = charArr.GetLength(0);
            int colLength = charArr.GetLength(1);

            if (row - 1 >= 0)
            {
                if (charArr[row - 1, col] == '*')
                {
                    count++;
                }
            }
            if (row + 1 < rowLength)
            {
                if (charArr[row + 1, col] == '*')
                {
                    count++;
                }
            }
            if (col - 1 >= 0)
            {
                if (charArr[row, col - 1] == '*')
                {
                    count++;
                }
            }
            if (col + 1 < colLength)
            {
                if (charArr[row, col + 1] == '*')
                {
                    count++;
                }
            }
            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (charArr[row - 1, col - 1] == '*')
                {
                    count++;
                }
            }
            if ((row - 1 >= 0) && (col + 1 < colLength))
            {
                if (charArr[row - 1, col + 1] == '*')
                {
                    count++;
                }
            }
            if ((row + 1 < rowLength) && (col - 1 >= 0))
            {
                if (charArr[row + 1, col - 1] == '*')
                {
                    count++;
                }
            }
            if ((row + 1 < rowLength) && (col + 1 < colLength))
            {
                if (charArr[row + 1, col + 1] == '*')
                {
                    count++;
                }
            }
            return char.Parse(count.ToString());
        }
    }
}
