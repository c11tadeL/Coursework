
namespace GameSudoku
{
    partial class Sudoku
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sudoku));
            this.ButtonLevel1 = new System.Windows.Forms.Button();
            this.ButtonLevel2 = new System.Windows.Forms.Button();
            this.ButtonLevel3 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonLevel1
            // 
            this.ButtonLevel1.BackColor = System.Drawing.Color.Transparent;
            this.ButtonLevel1.FlatAppearance.BorderSize = 0;
            this.ButtonLevel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLevel1.Font = new System.Drawing.Font("Book Antiqua", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLevel1.ForeColor = System.Drawing.Color.Black;
            this.ButtonLevel1.Location = new System.Drawing.Point(830, 388);
            this.ButtonLevel1.Name = "ButtonLevel1";
            this.ButtonLevel1.Size = new System.Drawing.Size(232, 53);
            this.ButtonLevel1.TabIndex = 0;
            this.ButtonLevel1.Text = "Level 1";
            this.ButtonLevel1.UseVisualStyleBackColor = false;
            this.ButtonLevel1.Click += new System.EventHandler(this.ButtonLevel1_Click);
            // 
            // ButtonLevel2
            // 
            this.ButtonLevel2.BackColor = System.Drawing.Color.Transparent;
            this.ButtonLevel2.FlatAppearance.BorderSize = 0;
            this.ButtonLevel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLevel2.Font = new System.Drawing.Font("Book Antiqua", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLevel2.ForeColor = System.Drawing.Color.Black;
            this.ButtonLevel2.Location = new System.Drawing.Point(830, 447);
            this.ButtonLevel2.Name = "ButtonLevel2";
            this.ButtonLevel2.Size = new System.Drawing.Size(232, 51);
            this.ButtonLevel2.TabIndex = 1;
            this.ButtonLevel2.Text = "Level 2";
            this.ButtonLevel2.UseVisualStyleBackColor = false;
            this.ButtonLevel2.Click += new System.EventHandler(this.ButtonLevel2_Click);
            // 
            // ButtonLevel3
            // 
            this.ButtonLevel3.BackColor = System.Drawing.Color.Transparent;
            this.ButtonLevel3.FlatAppearance.BorderSize = 0;
            this.ButtonLevel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLevel3.Font = new System.Drawing.Font("Book Antiqua", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLevel3.ForeColor = System.Drawing.Color.Black;
            this.ButtonLevel3.Location = new System.Drawing.Point(830, 504);
            this.ButtonLevel3.Name = "ButtonLevel3";
            this.ButtonLevel3.Size = new System.Drawing.Size(232, 53);
            this.ButtonLevel3.TabIndex = 2;
            this.ButtonLevel3.Text = "Level 3";
            this.ButtonLevel3.UseVisualStyleBackColor = false;
            this.ButtonLevel3.Click += new System.EventHandler(this.ButtonLevel3_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Book Antiqua", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(830, 563);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(232, 53);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Sudoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ButtonLevel3);
            this.Controls.Add(this.ButtonLevel2);
            this.Controls.Add(this.ButtonLevel1);
            this.Font = new System.Drawing.Font("Chiller", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sudoku";
            this.Text = "Sudoku";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonLevel1;
        private System.Windows.Forms.Button ButtonLevel2;
        private System.Windows.Forms.Button ButtonLevel3;
        private System.Windows.Forms.Button Exit;
    }
}

