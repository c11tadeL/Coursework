using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GameSudoku
{
    public static class BackgroundManager
    {
        public static void SetBackgroundImage(Form form, string imageName)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(basePath, imageName);
            if (File.Exists(imagePath))
            {
                Image backgroundImage = Image.FromFile(imagePath);
                form.BackgroundImage = backgroundImage;
                form.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                MessageBox.Show("Файл зображення не знайдено.");
            }
        }
    }
}
