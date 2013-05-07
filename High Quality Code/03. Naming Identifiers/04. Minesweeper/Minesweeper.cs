namespace Minesweeper
{
    using System;
    using System.Collections.Generic;

    public class Minesweeper
    {       
        private static void Main()
        {
            string playerCommand = string.Empty;
            char[,] playField = CreatePlayField();
            char[,] mineField = PutMinesIntoTheField();
            int openFields = 0;
            bool foundMine = false;
            List<HighScore> highScorePlayers = new List<HighScore>(6);
            int chosenRow = 0;
            int chosenColumn = 0;
            bool newGameStarted = true;
            const int NonMineFields = 35;
            bool areAllFieldsOpen = false;

            do
            {
                if (newGameStarted)
                {
                    Console.WriteLine("Welcome to Minesweeper! \nYou must find the fields without mines on them." +
                    "\nCommands: \n'top' for HiScores, \n'restart' for a new game, \n'exit' if you want to leave!");
                    RenderField(playField);
                    newGameStarted = false;
                }

                Console.Write("Please enter command or minefield coordinates: ");
                playerCommand = Console.ReadLine().Trim();
                if (playerCommand.Length >= 3)
                {
                    if (int.TryParse(playerCommand[0].ToString(), out chosenRow) &&
                    int.TryParse(playerCommand[2].ToString(), out chosenColumn) &&
                        chosenRow < playField.GetLength(0) && chosenColumn < playField.GetLength(1))
                    {
                        playerCommand = "turn";
                    }
                }

                switch (playerCommand)
                {
                    case "top":
                        TopScores(highScorePlayers);
                        break;

                    case "restart":
                        playField = CreatePlayField();
                        mineField = PutMinesIntoTheField();
                        RenderField(playField);
                        foundMine = false;
                        newGameStarted = false;
                        break;

                    case "exit":
                        Console.WriteLine("Goodbye!");
                        break;

                    case "turn":
                        if (mineField[chosenRow, chosenColumn] != '*')
                        {
                            if (mineField[chosenRow, chosenColumn] == '-')
                            {
                                PlayersMove(playField, mineField, chosenRow, chosenColumn);
                                openFields++;
                            }

                            if (NonMineFields == openFields)
                            {
                                areAllFieldsOpen = true;
                            }
                            else
                            {
                                RenderField(playField);
                            }
                        }
                        else
                        {
                            foundMine = true;
                        }

                        break;

                    default:
                        Console.WriteLine("\nNot a valid command!\n");
                        break;
                }

                if (foundMine)
                {
                    RenderField(mineField);
                    Console.Write("\nYou stepped on a mine! You've got {0} points. Enter a nickname: ", openFields);
                    string nickname = Console.ReadLine();
                    HighScore currentHighScore = new HighScore(nickname, openFields);
                    if (highScorePlayers.Count < 5)
                    {
                        highScorePlayers.Add(currentHighScore);
                    }
                    else
                    {
                        for (int i = 0; i < highScorePlayers.Count; i++)
                        {
                            if (highScorePlayers[i].Score < currentHighScore.Score)
                            {
                                highScorePlayers.Insert(i, currentHighScore);
                                highScorePlayers.RemoveAt(highScorePlayers.Count - 1);
                                break;
                            }
                        }
                    }

                    highScorePlayers.Sort((HighScore firstScore, HighScore secondScore) 
                        => secondScore.Name.CompareTo(firstScore.Name));
                    highScorePlayers.Sort((HighScore firstScore, HighScore secondScore) 
                        => secondScore.Score.CompareTo(firstScore.Score));
                    TopScores(highScorePlayers);

                    playField = CreatePlayField();
                    mineField = PutMinesIntoTheField();
                    openFields = 0;
                    foundMine = false;
                    newGameStarted = true;
                }

                if (areAllFieldsOpen)
                {
                    Console.WriteLine("\nCongratulations! You win!");
                    RenderField(mineField);
                    Console.WriteLine("Enter a nickname: ");
                    string nickname = Console.ReadLine();
                    HighScore currentHiScore = new HighScore(nickname, openFields);
                    highScorePlayers.Add(currentHiScore);
                    TopScores(highScorePlayers);
                    playField = CreatePlayField();
                    mineField = PutMinesIntoTheField();
                    openFields = 0;
                    areAllFieldsOpen = false;
                    newGameStarted = true;
                }
            }
            while (playerCommand != "exit");
            Console.WriteLine("Thank you for playing!");
            Console.Read();
        }

        private static void TopScores(List<HighScore> scores)
        {
            int numberOfRecordedHiScores = scores.Count;
            if (numberOfRecordedHiScores > 0)
            {
                Console.WriteLine("\nTop Scores:");
                for (int index = 0; index < numberOfRecordedHiScores; index += 1)
                {
                    Console.WriteLine("{0}. {1} --> {2} fields.", index + 1, scores[index].Name, scores[index].Score);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Top scores are empty!\n");
            }
        }

        private static void PlayersMove(char[,] playField, char[,] mineField, int row, int column)
        {
            char surroundingMines = GetNumberOfSurroundingMines(mineField, row, column);
            mineField[row, column] = surroundingMines;
            playField[row, column] = surroundingMines;
        }

        private static void RenderField(char[,] playField)
        {
            int rows = playField.GetLength(0);
            int columns = playField.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int row = 0; row < rows; row++)
            {
                Console.Write("{0} | ", row);
                for (int col = 0; col < columns; col++)
                {
                    Console.Write(string.Format("{0} ", playField[row, col]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreatePlayField()
        {
            int fieldRows = 5;
            int fieldColumns = 10;
            char[,] playField = new char[fieldRows, fieldColumns];
            for (int row = 0; row < fieldRows; row++)
            {
                for (int col = 0; col < fieldColumns; col++)
                {
                    playField[row, col] = '?';
                }
            }

            return playField;
        }

        private static char[,] PutMinesIntoTheField()
        {
            int fieldRows = 5;
            int fieldCols = 10;
            int numberOFMinesInTheField = 15;
            char[,] mineField = new char[fieldRows, fieldCols];

            for (int row = 0; row < fieldRows; row++)
            {
                for (int j = 0; j < fieldCols; j++)
                {
                    mineField[row, j] = '-';
                }
            }

            List<int> randomIndices = new List<int>();
            while (randomIndices.Count < numberOFMinesInTheField)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);
                if (!randomIndices.Contains(randomNumber))
                {
                    randomIndices.Add(randomNumber);
                }
            }

            foreach (int index in randomIndices)
            {
                int row = index / fieldCols;
                int column = index % fieldCols;
                if (column == 0 && index != 0)
                {
                    row--;
                    column = fieldCols;
                }
                else
                {
                    column++;
                }

                mineField[row, column - 1] = '*';
            }

            return mineField;
        }

        //// Unused method
        ////private static void smetki(char[,] playField)
        ////{
        ////    int kol = playField.GetLength(0);
        ////    int red = playField.GetLength(1);
        ////    for (int i = 0; i < kol; i++)
        ////    {
        ////        for (int j = 0; j < red; j++)
        ////        {
        ////            if (playField[i, j] != '*')
        ////            {
        ////                char kolkoo = kolko(playField, i, j);
        ////                playField[i, j] = kolkoo;
        ////            }
        ////        }
        ////    }
        ////}

        private static char GetNumberOfSurroundingMines(char[,] mineField, int chosenRow, int chosenColumn)
        {
            int numberOfSurroundingMines = 0;
            int rows = mineField.GetLength(0);
            int columns = mineField.GetLength(1);

            if (chosenRow - 1 >= 0)
            {
                if (mineField[chosenRow - 1, chosenColumn] == '*')
                {
                    numberOfSurroundingMines++;
                }
            }

            if (chosenRow + 1 < rows)
            {
                if (mineField[chosenRow + 1, chosenColumn] == '*')
                {
                    numberOfSurroundingMines++;
                }
            }

            if (chosenColumn - 1 >= 0)
            {
                if (mineField[chosenRow, chosenColumn - 1] == '*')
                {
                    numberOfSurroundingMines++;
                }
            }

            if (chosenColumn + 1 < columns)
            {
                if (mineField[chosenRow, chosenColumn + 1] == '*')
                {
                    numberOfSurroundingMines++;
                }
            }

            if ((chosenRow - 1 >= 0) && (chosenColumn - 1 >= 0))
            {
                if (mineField[chosenRow - 1, chosenColumn - 1] == '*')
                {
                    numberOfSurroundingMines++;
                }
            }

            if ((chosenRow - 1 >= 0) && (chosenColumn + 1 < columns))
            {
                if (mineField[chosenRow - 1, chosenColumn + 1] == '*')
                {
                    numberOfSurroundingMines++;
                }
            }

            if ((chosenRow + 1 < rows) && (chosenColumn - 1 >= 0))
            {
                if (mineField[chosenRow + 1, chosenColumn - 1] == '*')
                {
                    numberOfSurroundingMines++;
                }
            }

            if ((chosenRow + 1 < rows) && (chosenColumn + 1 < columns))
            {
                if (mineField[chosenRow + 1, chosenColumn + 1] == '*')
                {
                    numberOfSurroundingMines++;
                }
            }

            return char.Parse(numberOfSurroundingMines.ToString());
        }
    }
}
