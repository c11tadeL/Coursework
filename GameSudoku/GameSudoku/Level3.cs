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
    public partial class Level3 : Form
    {
        private SudokuGrid sudokuGrid;
        private SudokuSolver sudokuSolver;
        public Level3()
        {
            InitializeComponent();
            Load += Level3_Load;
        }

        private void Level3_Load(object sender, EventArgs e)
        {
            Width = ActiveForm.Width;
            Height = ActiveForm.Height;
            BackgroundImage = ActiveForm.BackgroundImage;
            BackgroundImageLayout = ActiveForm.BackgroundImageLayout;
            Icon = ActiveForm.Icon;
            WindowState = FormWindowState.Maximized;
            TextLabelCreator.CreateTextLabel(this, "Level 3");
            sudokuGrid = new SudokuGrid(this, 710, 310);
            sudokuSolver = new SudokuSolver();
            int[,] solvedSudoku = sudokuSolver.SolveSudoku(50);
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
                DialogResult result = MessageBox.Show("Рівень 3 успішно пройдено! \nДля того, щоб знову зіграти цей рівень натисність -\"Повторити\"\n", "Success", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);

                if (result == DialogResult.Retry)
                {
                    
                    GameLogic.OpenNextLevel<Level3>(this);
                }
                else
                {
                   
                }
            }
            else
            {
                DialogResult retryResult = MessageBox.Show("Ви допустились помилки!\nДля того, щоб зіграти цей рівень спочатку натисність -\"Повторити\" \nДля того, щоб залишитись на цьому рівні і знайти помилку натисніть -\"Відміна\"", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                if (retryResult == DialogResult.Retry)
                {
                    
                    GameLogic.OpenNextLevel<Level3>(this);
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
