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
    public partial class Sudoku : Form
    {
        public Sudoku()
        {
            InitializeComponent();
            BackgroundManager.SetBackgroundImage(this, "background2.jpg");
            TextLabelCreator.CreateTextLabel(this, "Sudoku");
        }

        private void ButtonLevel1_Click(object sender, EventArgs e)
        {
            OpenLevelForm<Level1>("Level 1");
        }

        private void ButtonLevel2_Click(object sender, EventArgs e)
        {
            OpenLevelForm<Level2>("Level 2");
        }

        private void ButtonLevel3_Click(object sender, EventArgs e)
        {
            OpenLevelForm<Level3>("Level 3");
        }
        private void OpenLevelForm<T>(string levelName) where T : Form, new()
        {
            T levelForm = new T
            {
                Width = ActiveForm.Width,
                Height = ActiveForm.Height,
                BackgroundImage = ActiveForm.BackgroundImage,
                BackgroundImageLayout = ActiveForm.BackgroundImageLayout
            };
            levelForm.Show();   
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
