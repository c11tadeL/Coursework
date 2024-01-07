using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSudoku
{
    public partial class Level2 : Form
    {
        private SudokuGrid sudokuGrid;
        private SudokuSolver sudokuSolver;
        public Level2()
        {
            InitializeComponent();
            Load += Level2_Load;
        }

        private void Level2_Load(object sender, EventArgs e)
        {
            Width = ActiveForm.Width;
            Height = ActiveForm.Height;
            BackgroundImage = ActiveForm.BackgroundImage;
            BackgroundImageLayout = ActiveForm.BackgroundImageLayout;
            Icon = ActiveForm.Icon;
            WindowState = FormWindowState.Maximized;
            TextLabelCreator.CreateTextLabel(this, "Level 2");
            sudokuGrid = new SudokuGrid(this, 710, 310);
            sudokuSolver = new SudokuSolver();
            int[,] solvedSudoku = sudokuSolver.SolveSudoku(35);
            GameLogic.InitializeSudokuGrid(sudokuGrid, solvedSudoku);
            Button checkButton = GameLogic.CreateCheckButton(this, "Check Solution", CheckButton_Click);
            Button helpButton = GameLogic.CreateHelpButton(this, "?", HelpButton_Click);
            Button exitButton = GameLogic.CreateExitButton(this, "Exit");
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            int[,] currentSudoku = sudokuGrid.GetSudokuBoard();

            if (GameLogic.IsSudokuCorrect(currentSudoku, sudokuSolver))
            {
                DialogResult result = MessageBox.Show("Рівень 2 успішно пройдено! \nДля переходу на новий рівень натисність - \"Так\"\nДля того, щоб знову зіграти цей рівень натисніть - \"Ні\"", "Успіх!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    GameLogic.OpenNextLevel<Level3>(this);
                }
                else
                {
                    
                    GameLogic.OpenNextLevel<Level2>(this);
                }
            }
            else
            {
                DialogResult retryResult = MessageBox.Show("Ви допустились помилки!\nДля того, щоб зіграти цей рівень спочатку натисність -\"Повторити\" \nДля того, щоб залишитись на цьому рівні і знайти помилку натисніть -\"Відміна\"", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                if (retryResult == DialogResult.Retry)
                {
                    GameLogic.OpenNextLevel<Level2>(this);
                }
                else
                {

                }

            }

        }
        private void HelpButton_Click(object sender, EventArgs e)
        {
            GameLogic.ShowRules();
        }
    }
}
