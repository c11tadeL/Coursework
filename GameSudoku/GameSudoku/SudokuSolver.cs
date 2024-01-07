using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSudoku
{
    public class SudokuSolver
    {
 
        private int[,] originalSolution;
        private int[,] sudokuBoard;

        public SudokuSolver()
        {
            originalSolution = new int[9, 9];
            sudokuBoard = new int[9, 9];
        }

        public int[,] SolveSudoku(int percentageToFill)
        {
            Random random = new Random();
            sudokuBoard = new int[9, 9];
            FillSudoku(0, 0);
            Array.Copy(sudokuBoard, originalSolution, sudokuBoard.Length);
            RemoveNumbers(percentageToFill, random);
            return sudokuBoard;
        }

        private bool FillSudoku(int row, int col)
        {
            if (row == 9)
            {
                row = 0;
                if (++col == 9)
                    return true;
            }
            List<int> numbers = Enumerable.Range(1, 9).ToList();
            numbers = ShuffleList(numbers);
            foreach (int num in numbers)
            {
                if (IsValidPlacement(row, col, num))
                {
                    sudokuBoard[row, col] = num;

                    if (FillSudoku(row + 1, col) == true)
                        return true;

                    sudokuBoard[row, col] = 0;
                }
            }

            return false;
        }

        private bool IsValidPlacement(int row, int col, int num)
        {
            for (int i = 0; i < 9; i++)
            {
                if (sudokuBoard[row, i] == num || sudokuBoard[i, col] == num || sudokuBoard[row - row % 3 + i / 3, col - col % 3 + i % 3] == num)
                    return false;
            }

            return true;
        }

        private void RemoveNumbers(int percentageToFill, Random random)
        {
            int totalCells = 81;
            int cellsToFill = (int)(percentageToFill / 100.0 * totalCells);

            while (cellsToFill > 0)
            {
                int row = random.Next(9);
                int col = random.Next(9);

                if (sudokuBoard[row, col] != 0)
                {
                    sudokuBoard[row, col] = 0;
                    cellsToFill--;
                }
            }
        }
        public int[,] GetOriginalSolution()
        {
            return originalSolution;
        }

        private List<T> ShuffleList<T>(List<T> list)
        {
            Random random = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return list;
        }
    }
}

