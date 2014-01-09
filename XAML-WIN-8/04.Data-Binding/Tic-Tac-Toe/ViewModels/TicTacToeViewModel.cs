using System;
using System.IO;
using System.Windows.Input;
using Windows.UI.Input;
using TicTacToe.Annotations;
using TicTacToe.Behavior;

namespace TicTacToe.ViewModels
{
    public class TicTacToeViewModel : ViewModelBase
    {
        private bool _inTurn = false;
        private bool EndGame { [UsedImplicitly] get; set; }


        public string Winner
        {
            get { return _winner; }
            set
            {
                _winner = value;
                this.OnPropertyChanged("Winner");
            }
        }

        public string[,] GameMatrix { get; set; }

        #region row properties

        #region Private
        private string _winner;
        private string _row0Col0;
        private string _row0Col1;
        private string _row0Col2;

        private string _row1Col0;
        private string _row1Col1;
        private string _row1Col2;

        private string _row2Col0;
        private string _row2Col1;
        private string _row2Col2;
        #endregion

        #region First Row
        public string Row0Col0
        {
            get { return _row0Col0; }
            set
            {
                _row0Col0 = value;
                this.OnPropertyChanged("Row0Col0");
            }
        }

        public string Row0Col1
        {
            get { return _row0Col1; }
            set
            {
                _row0Col1 = value;
                this.OnPropertyChanged("Row0Col1");
            }
        }

        public string Row0Col2
        {
            get { return _row0Col2; }
            set
            {
                _row0Col2 = value;
                this.OnPropertyChanged("Row0Col2");
            }
        }
        #endregion

        #region Second Row
        public string Row1Col0
        {
            get { return _row1Col0; }
            set
            {
                _row1Col0 = value;
                this.OnPropertyChanged("Row1Col0");
            }
        }

        public string Row1Col1
        {
            get { return _row1Col1; }
            set
            {
                _row1Col1 = value;
                this.OnPropertyChanged("Row1Col1");
            }
        }

        public string Row1Col2
        {
            get { return _row1Col2; }
            set
            {
                _row1Col2 = value;
                this.OnPropertyChanged("Row1Col2");
            }
        }
        #endregion

        #region Third Row
        public string Row2Col0
        {
            get { return _row2Col0; }
            set
            {
                _row2Col0 = value;
                this.OnPropertyChanged("Row2Col0");
            }
        }

        public string Row2Col1
        {
            get { return _row2Col1; }
            set
            {
                _row2Col1 = value;
                this.OnPropertyChanged("Row2Col1");
            }
        }

        public string Row2Col2
        {
            get { return _row2Col2; }
            set
            {
                _row2Col2 = value;
                this.OnPropertyChanged("Row2Col2");
            }
        }
        #endregion

        #endregion

        public TicTacToeViewModel()
        {
            this.GameMatrix = new string[,]
            {
                {Row0Col0, Row0Col1, Row0Col2},
                {Row1Col0, Row1Col1, Row1Col2},
                {Row2Col0, Row2Col1, Row2Col2},
            };
        }

        #region first button command
        private ICommand _row0Col0ClickCommand;

        public ICommand Row0Col0ClickCommand
        {
            get
            {
                if (this._row0Col0ClickCommand == null)
                {
                    this._row0Col0ClickCommand = new DelegateCommand<TicTacToeViewModel>(this.HandleRow0Col0ClickCommand);
                }
                return this._row0Col0ClickCommand;
            }
        }

        private void HandleRow0Col0ClickCommand(TicTacToeViewModel parameter)
        {
            if (IsFree(GameMatrix[0, 0])) return;

            if (_inTurn == false)
            {
                this.GameMatrix[0, 0] = "X";
                this.Row0Col0 = this.GameMatrix[0, 0];
                _inTurn = true;
            }
            else
            {
                this.GameMatrix[0, 0] = "O";
                this.Row0Col0 = this.GameMatrix[0, 0];
                _inTurn = false;
            }
            CheckForWinner();
        }
        #endregion

        #region second button command
        private ICommand _row0Col01ClickCommand;

        public ICommand Row0Col1ClickCommand
        {
            get
            {
                if (this._row0Col01ClickCommand == null)
                {
                    this._row0Col01ClickCommand = new DelegateCommand<TicTacToeViewModel>(this.HandleRow0Col1ClickCommand);
                }
                return this._row0Col01ClickCommand;
            }
        }

        private void HandleRow0Col1ClickCommand(TicTacToeViewModel parameter)
        {
            if (IsFree(GameMatrix[0, 1])) return;

            if (_inTurn == false)
            {
                this.GameMatrix[0, 1] = "X";
                this.Row0Col1 = this.GameMatrix[0, 1];
                _inTurn = true;
            }
            else
            {
                this.GameMatrix[0, 1] = "O";
                this.Row0Col1 = this.GameMatrix[0, 1];
                _inTurn = false;
            }
            CheckForWinner();
        }
        #endregion

        #region third button command
        private ICommand _row0Col02ClickCommand;

        public ICommand Row0Col2ClickCommand
        {
            get
            {
                if (this._row0Col02ClickCommand == null)
                {
                    this._row0Col02ClickCommand = new DelegateCommand<TicTacToeViewModel>(this.HandleRow0Col2ClickCommand);
                }
                return this._row0Col02ClickCommand;
            }
        }

        private void HandleRow0Col2ClickCommand(TicTacToeViewModel parameter)
        {
            if (IsFree(GameMatrix[0, 2])) return;

            if (_inTurn == false)
            {
                this.GameMatrix[0, 2] = "X";
                this.Row0Col2 = this.GameMatrix[0, 2];
                _inTurn = true;
            }
            else
            {
                this.GameMatrix[0, 2] = "O";
                this.Row0Col2 = this.GameMatrix[0, 2];
                _inTurn = false;
            }
            CheckForWinner();
        }
        #endregion

        #region fournd button command
        private ICommand _row1Col0ClickCommand;

        public ICommand Row1Col0ClickCommand
        {
            get
            {
                if (this._row1Col0ClickCommand == null)
                {
                    this._row1Col0ClickCommand = new DelegateCommand<TicTacToeViewModel>(this.HandleRow1Col0ClickCommand);
                }
                return this._row1Col0ClickCommand;
            }
        }

        private void HandleRow1Col0ClickCommand(TicTacToeViewModel parameter)
        {
            if (IsFree(GameMatrix[1, 0])) return;

            if (_inTurn == false)
            {
                this.GameMatrix[1, 0] = "X";
                this.Row1Col0 = this.GameMatrix[1, 0];
                _inTurn = true;
            }
            else
            {
                this.GameMatrix[1, 0] = "O";
                this.Row1Col0 = this.GameMatrix[1, 0];
                _inTurn = false;
            }
            CheckForWinner();
        }
        #endregion

        #region fifth button command
        private ICommand _row1Col1ClickCommand;

        public ICommand Row1Col1ClickCommand
        {
            get
            {
                if (this._row1Col1ClickCommand == null)
                {
                    this._row1Col1ClickCommand = new DelegateCommand<TicTacToeViewModel>(this.HandleRow1Col1ClickCommand);
                }
                return this._row1Col1ClickCommand;
            }
        }

        private void HandleRow1Col1ClickCommand(TicTacToeViewModel parameter)
        {
            if (IsFree(GameMatrix[1, 1])) return;

            if (_inTurn == false)
            {
                this.GameMatrix[1, 1] = "X";
                this.Row1Col1 = this.GameMatrix[1, 1];
                _inTurn = true;
            }
            else
            {
                this.GameMatrix[1, 1] = "O";
                this.Row1Col1 = this.GameMatrix[1, 1];
                _inTurn = false;
            }
            CheckForWinner();
        }
        #endregion

        #region sixth button command
        private ICommand _row1Col2ClickCommand;

        public ICommand Row1Col2ClickCommand
        {
            get
            {
                if (this._row1Col2ClickCommand == null)
                {
                    this._row1Col2ClickCommand = new DelegateCommand<TicTacToeViewModel>(this.HandleRow1Col2ClickCommand);
                }
                return this._row1Col2ClickCommand;
            }
        }

        private void HandleRow1Col2ClickCommand(TicTacToeViewModel parameter)
        {
            if (IsFree(GameMatrix[1, 2])) return;

            if (_inTurn == false)
            {
                this.GameMatrix[1, 2] = "X";
                this.Row1Col2 = this.GameMatrix[1, 2];
                _inTurn = true;
            }
            else
            {
                this.GameMatrix[1, 2] = "O";
                this.Row1Col2 = this.GameMatrix[1, 2];
                _inTurn = false;
            }
            CheckForWinner();
        }
        #endregion

        #region sevent button command
        private ICommand _row2Col0ClickCommand;

        public ICommand Row2Col0ClickCommand
        {
            get
            {
                if (this._row2Col0ClickCommand == null)
                {
                    this._row2Col0ClickCommand = new DelegateCommand<TicTacToeViewModel>(this.HandleRow2Col0ClickCommand);
                }
                return this._row2Col0ClickCommand;
            }
        }

        private void HandleRow2Col0ClickCommand(TicTacToeViewModel parameter)
        {
            if (IsFree(GameMatrix[2, 0])) return;

            if (_inTurn == false)
            {
                this.GameMatrix[2, 0] = "X";
                this.Row2Col0 = this.GameMatrix[2, 0];
                _inTurn = true;
            }
            else
            {
                this.GameMatrix[2, 0] = "O";
                this.Row2Col0 = this.GameMatrix[2, 0];
                _inTurn = false;
            }
            CheckForWinner();
        }
        #endregion

        #region eighth button command
        private ICommand _row2Col1ClickCommand;

        public ICommand Row2Col1ClickCommand
        {
            get
            {
                if (this._row2Col1ClickCommand == null)
                {
                    this._row2Col1ClickCommand = new DelegateCommand<TicTacToeViewModel>(this.HandleRow2Col1ClickCommand);
                }
                return this._row2Col1ClickCommand;
            }
        }

        private void HandleRow2Col1ClickCommand(TicTacToeViewModel parameter)
        {
            if (IsFree(GameMatrix[2, 1])) return;

            if (_inTurn == false)
            {
                this.GameMatrix[2, 1] = "X";
                this.Row2Col1 = this.GameMatrix[2, 1];
                _inTurn = true;
            }
            else
            {
                this.GameMatrix[2, 1] = "O";
                this.Row2Col1 = this.GameMatrix[2, 1];
                _inTurn = false;
            }
            CheckForWinner();
        }
        #endregion

        #region nineth button command
        private ICommand _row2Col2ClickCommand;


        public ICommand Row2Col2ClickCommand
        {
            get
            {
                if (this._row2Col2ClickCommand == null)
                {
                    this._row2Col2ClickCommand = new DelegateCommand<TicTacToeViewModel>(this.HandleRow2Col2ClickCommand);
                }
                return this._row2Col2ClickCommand;
            }
        }

        private void HandleRow2Col2ClickCommand(TicTacToeViewModel parameter)
        {
            if (IsFree(GameMatrix[2, 2])) return;

            if (_inTurn == false)
            {
                this.GameMatrix[2, 2] = "X";
                this.Row2Col2 = this.GameMatrix[2, 2];
                _inTurn = true;
            }
            else
            {
                this.GameMatrix[2, 2] = "O";
                this.Row2Col2 = this.GameMatrix[2, 2];
                _inTurn = false;
            }
            CheckForWinner();
        }
        #endregion

        private void CheckForWinner()
        {
            var equalSights = 1;
            string currentValue = null;
            #region check rows
            for (int i = 0; i < this.GameMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.GameMatrix.GetLength(1) - 1; j++)
                {
                    if (GameMatrix[i, j] != null)
                    {
                        if (GameMatrix[i, j] == GameMatrix[i, j + 1])
                        {
                            equalSights++;
                        }
                    }
                    currentValue = GameMatrix[i, j];
                }
                if (equalSights == 3)
                {
                    this.Winner = "Winner " + currentValue;
                    this.EndGame = true;
                }
                equalSights = 1;
            }
            #endregion
            equalSights = 1;

            #region check cols
            for (int i = 0; i < GameMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < GameMatrix.GetLength(1) - 1; j++)
                {
                    if (GameMatrix[j, i] != null)
                    {
                        if (GameMatrix[j, i] == GameMatrix[j + 1, i])
                        {
                            equalSights++;
                        }
                    }
                    currentValue = GameMatrix[j, i];
                }
                if (equalSights == 3)
                {
                    this.Winner = "Winner " + currentValue;
                    this.EndGame = true;
                }
                equalSights = 1;
            }
            #endregion

            #region check diagonals
            equalSights = 1;

            for (int i = 0, j = 0; i < 2; i++, j++)
            {
                if (GameMatrix[i, j] != null)
                {
                    if (GameMatrix[i, j] == GameMatrix[i + 1, j + 1])
                    {
                        equalSights++;
                    }
                    currentValue = GameMatrix[i, j];
                }
                if (equalSights == 3)
                {
                    this.Winner = "Winner " + currentValue;
                    this.EndGame = true;
                }

            }

            equalSights = 1;

            for (int i = 0, j = 2; i < 2; i++, j--)
            {
                if (GameMatrix[i, j] != null)
                {
                    if (GameMatrix[i, j] == GameMatrix[i + 1, j - 1])
                    {
                        equalSights++;
                    }
                    currentValue = GameMatrix[i, j];
                }
                if (equalSights == 3)
                {
                    this.Winner = "Winner " + currentValue;
                    this.EndGame = true;
                }

            }
            #endregion

            #region check for no winner
            int counter = 0;

            for (int i = 0; i < this.GameMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.GameMatrix.GetLength(1); j++)
                {
                    if (GameMatrix[i, j] != null)
                    {
                        counter++;
                    }
                }
            }
            if (counter == 9)
            {
                this.Winner = "Nobody Wins";
                this.EndGame = true;
            }
            #endregion
        }

        private bool IsFree(string matrixRowOrCol)
        {
            if (matrixRowOrCol == "X" || matrixRowOrCol == "O")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}