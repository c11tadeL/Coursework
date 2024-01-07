using System.Drawing;
using System.Windows.Forms;
using System;

namespace GameSudoku
{
    public class SudokuGrid
    {
        private const int GridSize = 9;
        private const int CellSize = 50;
        private const int BorderSize = 2;

        private Button[,] sudokuButtons;

        public SudokuGrid(Form parentForm, int offsetX, int offsetY)
        {
            InitializeSudokuGrid(parentForm, offsetX, offsetY);
        }

        private void InitializeSudokuGrid(Form parentForm, int offsetX, int offsetY)
        {
            sudokuButtons = new Button[GridSize, GridSize];
            int gridSizePixels = GridSize * CellSize + (GridSize - 1) * BorderSize;
            Panel sudokuPanel = new Panel
            {
                Location = new Point(offsetX, offsetY),
                Width = gridSizePixels + 2,
                Height = gridSizePixels + 2,
                BorderStyle = BorderStyle.FixedSingle
            };
            parentForm.Controls.Add(sudokuPanel);
            for (int row = 0; row < GridSize; row++)
            {
                for (int col = 0; col < GridSize; col++)
                {
                    Button button = new Button
                    {
                        Width = CellSize,
                        Height = CellSize,
                        Location = new Point(col * (CellSize + BorderSize),
                                             row * (CellSize + BorderSize)),
                        Font = new Font("Arial", 16),
                        Tag = 0,
                        Padding = new Padding(0),
                        BackColor = Color.LightGray,
                    };

                    button.Click += SudokuButton_Click;

                    sudokuPanel.Controls.Add(button);
                    sudokuButtons[row, col] = button;

                    if (col % 3 == 2 && col < GridSize - 1)
                    {
                        Label verticalLine = new Label
                        {
                            Width = BorderSize,
                            Height = gridSizePixels - 2,
                            Location = new Point(button.Right, 1),
                            BackColor = Color.Black
                        };

                        sudokuPanel.Controls.Add(verticalLine);
                    }

                    if (row % 3 == 2 && row < GridSize - 1)
                    {
                        Label horizontalLine = new Label
                        {
                            Width = gridSizePixels - 2,
                            Height = BorderSize,
                            Location = new Point(1, button.Bottom),
                            BackColor = Color.Black
                        };

                        sudokuPanel.Controls.Add(horizontalLine);
                    }
                }
            }
            Label borderLine = new Label
            {
                Width = gridSizePixels + BorderSize * 2 + 2,
                Height = gridSizePixels + BorderSize * 2 + 2,
                Location = new Point(offsetX - BorderSize, offsetY - BorderSize),
                BackColor = Color.Black
            };
            parentForm.Controls.Add(borderLine);


        }
        public void DisableButton(int row, int col)
        {
            sudokuButtons[row, col].Enabled = false;
        }

        public void SetButtonValue(int row, int col, int value)
        {
            sudokuButtons[row, col].Text = value.ToString();
            sudokuButtons[row, col].Tag = value;
        }
        private void SudokuButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int currentValue = (int)clickedButton.Tag;

            currentValue = (currentValue % 9) + 1;

            clickedButton.Tag = currentValue;
            clickedButton.Text = currentValue.ToString();
        }
        public int[,] GetSudokuBoard()
        {
            int[,] board = new int[GridSize, GridSize];
            for (int row = 0; row < GridSize; row++)
            {
                for (int col = 0; col < GridSize; col++)
                {
                    board[row, col] = (int)sudokuButtons[row, col].Tag;
                }
            }
            return board;
        }
    }
}
