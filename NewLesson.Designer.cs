
namespace it_s_base
{
    partial class NewLesson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CloseButton = new System.Windows.Forms.Button();
            this.AddLessonButton = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.TextBox();
            this.Theme = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.LessonBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.OrangeRed;
            this.CloseButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.CloseButton.Location = new System.Drawing.Point(161, 120);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(88, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AddLessonButton
            // 
            this.AddLessonButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddLessonButton.BackColor = System.Drawing.Color.LightGreen;
            this.AddLessonButton.Location = new System.Drawing.Point(260, 120);
            this.AddLessonButton.Name = "AddLessonButton";
            this.AddLessonButton.Size = new System.Drawing.Size(88, 23);
            this.AddLessonButton.TabIndex = 1;
            this.AddLessonButton.Text = "Добавить урок";
            this.AddLessonButton.UseVisualStyleBackColor = false;
            this.AddLessonButton.Click += new System.EventHandler(this.AddLessonButton_Click);
            // 
            // Date
            // 
            this.Date.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Date.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Date.Location = new System.Drawing.Point(260, 39);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(160, 20);
            this.Date.TabIndex = 3;
            // 
            // Theme
            // 
            this.Theme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Theme.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Theme.Location = new System.Drawing.Point(260, 66);
            this.Theme.Name = "Theme";
            this.Theme.Size = new System.Drawing.Size(160, 20);
            this.Theme.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.BackColor = System.Drawing.Color.GreenYellow;
            this.textBox5.Location = new System.Drawing.Point(89, 12);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(160, 20);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "Название урока";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.BackColor = System.Drawing.Color.GreenYellow;
            this.textBox6.Location = new System.Drawing.Point(89, 38);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(160, 20);
            this.textBox6.TabIndex = 7;
            this.textBox6.Text = "Дата проведения";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.BackColor = System.Drawing.Color.GreenYellow;
            this.textBox7.Location = new System.Drawing.Point(89, 66);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(160, 20);
            this.textBox7.TabIndex = 8;
            this.textBox7.Text = "Тема урока";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LessonBox
            // 
            this.LessonBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LessonBox.FormattingEnabled = true;
            this.LessonBox.Location = new System.Drawing.Point(260, 12);
            this.LessonBox.Name = "LessonBox";
            this.LessonBox.Size = new System.Drawing.Size(160, 21);
            this.LessonBox.TabIndex = 11;
            // 
            // NewLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(647, 201);
            this.Controls.Add(this.LessonBox);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Theme);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.AddLessonButton);
            this.Controls.Add(this.CloseButton);
            this.Name = "NewLesson";
            this.Text = "Новый урок";
            this.Load += new System.EventHandler(this.NewLesson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button AddLessonButton;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.TextBox Theme;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox LessonBox;
    }
}