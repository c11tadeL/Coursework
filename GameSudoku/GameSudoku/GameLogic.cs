using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GameSudoku
{
    class GameLogic
    {
        public static bool IsSudokuCorrect(int[,] currentSudoku, SudokuSolver sudokuSolver)
        {
            int[,] originalSolution = sudokuSolver.GetOriginalSolution();

            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    int expectedValue = originalSolution[row, col];
                    int userValue = currentSudoku[row, col];

                    if ((expectedValue != userValue && expectedValue != 0) || (userValue != 0 && expectedValue == 0))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static void OpenNextLevel<T>(Form currentForm) where T : Form, new()
        {
            T nextLevelForm = new T
            {
                Width = currentForm.Width,
                Height = currentForm.Height,
                BackgroundImage = currentForm.BackgroundImage,
                BackgroundImageLayout = currentForm.BackgroundImageLayout
            };

            nextLevelForm.Show();
            currentForm.Close();
        }
        public static void InitializeSudokuGrid(SudokuGrid sudokuGrid, int[,] solvedSudoku)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (solvedSudoku[row, col] != 0)
                    {
                        sudokuGrid.SetButtonValue(row, col, solvedSudoku[row, col]);
                        sudokuGrid.DisableButton(row, col);
                    }
                }
            }
        }
        public static Button CreateCheckButton(Form form, string buttonText, EventHandler clickHandler)
        {
            Button checkButton = new Button
            {
                Text = buttonText,
                Size = new System.Drawing.Size(185, 50),
                Location = new System.Drawing.Point(855, 260),
                BackColor = Color.Transparent, 
                FlatStyle = FlatStyle.Flat, 
                FlatAppearance = { BorderSize = 0 }, 
                Font = new Font("Arial", 18, FontStyle.Bold), 
                ForeColor = Color.Black, 
            };
            checkButton.Click += clickHandler;
            form.Controls.Add(checkButton);
            return checkButton;
        }
        public static Button CreateExitButton(Form form, string buttonText)
        {
            Button exitButton = new Button
            {
                Text = buttonText,
                Size = new Size(185, 50), 
                Location = new Point(855, 780), 
                BackColor = Color.Transparent, 
                FlatStyle = FlatStyle.Flat, 
                FlatAppearance = { BorderSize = 0 }, 
                Font = new Font("Arial", 18, FontStyle.Bold), 
                ForeColor = Color.Black, 
            };

            exitButton.Click += (sender, e) => form.Close(); 

            form.Controls.Add(exitButton);

            return exitButton;
        }

        public static Button CreateHelpButton(Form form, string buttonText, EventHandler clickHandler)
        {
            Button helpButton = new Button
            {
                Text = buttonText,
                Size = new Size(60, 60), 
                Location = new Point(1870, 965), 
                BackColor = Color.Transparent, 
                FlatStyle = FlatStyle.Flat, 
                FlatAppearance = { BorderSize = 0 }, 
                Font = new Font("Arial", 18, FontStyle.Bold), 
                ForeColor = Color.Black, 
            };

            helpButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 255, 255, 255); // Цвет при наведении мыши (можете настроить под свои требования)

            helpButton.Click += clickHandler;
            form.Controls.Add(helpButton);

            return helpButton;
        }

        public static void ShowRules()
        {
            string rulesText = "\n1. Заповнiть сiтку 9x9 цифрами від 1 до 9. Для цього натискайте на комірку відповідну кількість разів. \n2. Кожна цифра повинна зустрічатися лише один раз у кожному рядку, стовпці та підсітці 3x3.\n3. Цифри, які згенерувались на початку - не можуть бути змінені.\n4. Для того, щоб перевірити розв'язок натисніть  \"Check\"";
            MessageBox.Show(rulesText, "Правила гри Sudoku", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

