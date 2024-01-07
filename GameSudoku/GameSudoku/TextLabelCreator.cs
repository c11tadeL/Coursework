using System.Drawing;
using System.Windows.Forms;
using System;

namespace GameSudoku
{
    class TextLabelCreator
    {
        public static void CreateTextLabel(Control container, string labelText)
        {
            Label labelSudoku = new Label
            {
                Text = labelText,
                Font = new Font("Chiller", 128, FontStyle.Bold),
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent,
                Width = 650,
                Height = 175,
                Location = new Point((container.Width - 650) / 2, 0)
            };

            container.Controls.Add(labelSudoku);
        }
    }
}
