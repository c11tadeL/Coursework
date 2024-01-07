using System;
using System.Windows.Forms;

namespace GameSudoku
{
    partial class Level1 : Form
    {
        private SudokuGrid sudokuGrid;
        private SudokuSolver sudokuSolver;

        public Level1()
        {
            InitializeComponent();
            Load += Level1_Load;
        }

        private void Level1_Load(object sender, EventArgs e)
        {
            Width = ActiveForm.Width;
            Height = ActiveForm.Height;
            BackgroundImage = ActiveForm.BackgroundImage;
            BackgroundImageLayout = ActiveForm.BackgroundImageLayout;
            Icon = ActiveForm.Icon;
            WindowState = FormWindowState.Maximized;
            TextLabelCreator.CreateTextLabel(this, "Level 1");
            sudokuGrid = new SudokuGrid(this, 710, 310);
            sudokuSolver = new SudokuSolver();
            int[,] solvedSudoku = sudokuSolver.SolveSudoku(20);
            GameLogic.InitializeSudokuGrid(sudokuGrid, solvedSudoku);
            Button checkButton = GameLogic.CreateCheckButton(this, "Check", CheckButton_Click);
            Button helpButton = GameLogic.CreateHelpButton(this, "?", HelpButton_Click);
            Button exitButton = GameLogic.CreateExitButton(this, "Exit");
        }
        private void CheckButton_Click(object sender, EventArgs e)
        {
            int[,] currentSudoku = sudokuGrid.GetSudokuBoard();
            if (GameLogic.IsSudokuCorrect(currentSudoku, sudokuSolver))
            {
                DialogResult result = MessageBox.Show("Рівень 1 успішно пройдено! \nДля переходу на новий рівень натисність - \"Так\"\nДля того, щоб знову зіграти цей рівень натисніть - \"Ні\"", "Успіх!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    GameLogic.OpenNextLevel<Level2>(this);
                }
                else
                {
                   
                    GameLogic.OpenNextLevel<Level1>(this);
                }
            }
            else
            {
                DialogResult retryResult = MessageBox.Show("Ви допустились помилки!\nДля того, щоб зіграти цей рівень спочатку натисність -\"Повторити\" \nДля того, щоб залишитись на цьому рівні і знайти помилку натисніть -\"Відміна\"", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                if (retryResult == DialogResult.Retry)
                {
                    
                    GameLogic.OpenNextLevel<Level1>(this);
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
