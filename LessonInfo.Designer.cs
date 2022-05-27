
namespace it_s_base
{
    partial class LessonInfo
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
            this.updateButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.addGradeButton = new System.Windows.Forms.Button();
            this.lessonInfoGrid = new System.Windows.Forms.DataGridView();
            this.lessonTeacher = new System.Windows.Forms.TextBox();
            this.lessonDate = new System.Windows.Forms.TextBox();
            this.lessonTheme = new System.Windows.Forms.TextBox();
            this.lessonName = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lessonInfoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updateButton.BackColor = System.Drawing.Color.FloralWhite;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.ForeColor = System.Drawing.Color.Crimson;
            this.updateButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.updateButton.Location = new System.Drawing.Point(545, 80);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(210, 49);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Обновить";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.closeButton.BackColor = System.Drawing.Color.FloralWhite;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.Crimson;
            this.closeButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeButton.Location = new System.Drawing.Point(299, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(210, 49);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // addGradeButton
            // 
            this.addGradeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addGradeButton.BackColor = System.Drawing.Color.FloralWhite;
            this.addGradeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addGradeButton.ForeColor = System.Drawing.Color.Crimson;
            this.addGradeButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addGradeButton.Location = new System.Drawing.Point(545, 15);
            this.addGradeButton.Name = "addGradeButton";
            this.addGradeButton.Size = new System.Drawing.Size(210, 49);
            this.addGradeButton.TabIndex = 4;
            this.addGradeButton.Text = "Добавить оценку";
            this.addGradeButton.UseVisualStyleBackColor = false;
            this.addGradeButton.Click += new System.EventHandler(this.addGradeButton_Click);
            // 
            // lessonInfoGrid
            // 
            this.lessonInfoGrid.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.lessonInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lessonInfoGrid.Location = new System.Drawing.Point(0, 140);
            this.lessonInfoGrid.Name = "lessonInfoGrid";
            this.lessonInfoGrid.Size = new System.Drawing.Size(788, 298);
            this.lessonInfoGrid.TabIndex = 7;
            // 
            // lessonTeacher
            // 
            this.lessonTeacher.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lessonTeacher.Location = new System.Drawing.Point(156, 114);
            this.lessonTeacher.Name = "lessonTeacher";
            this.lessonTeacher.ReadOnly = true;
            this.lessonTeacher.Size = new System.Drawing.Size(100, 20);
            this.lessonTeacher.TabIndex = 15;
            this.lessonTeacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lessonDate
            // 
            this.lessonDate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lessonDate.Location = new System.Drawing.Point(156, 80);
            this.lessonDate.Name = "lessonDate";
            this.lessonDate.ReadOnly = true;
            this.lessonDate.Size = new System.Drawing.Size(100, 20);
            this.lessonDate.TabIndex = 14;
            this.lessonDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lessonTheme
            // 
            this.lessonTheme.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lessonTheme.Location = new System.Drawing.Point(156, 44);
            this.lessonTheme.Name = "lessonTheme";
            this.lessonTheme.ReadOnly = true;
            this.lessonTheme.Size = new System.Drawing.Size(100, 20);
            this.lessonTheme.TabIndex = 13;
            this.lessonTheme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lessonName
            // 
            this.lessonName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lessonName.Location = new System.Drawing.Point(156, 12);
            this.lessonName.Name = "lessonName";
            this.lessonName.ReadOnly = true;
            this.lessonName.Size = new System.Drawing.Size(100, 20);
            this.lessonName.TabIndex = 12;
            this.lessonName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.GreenYellow;
            this.textBox5.Location = new System.Drawing.Point(50, 114);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 19;
            this.textBox5.Text = "ФИО учителя";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.GreenYellow;
            this.textBox6.Location = new System.Drawing.Point(50, 80);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 18;
            this.textBox6.Text = "Дата проведения";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.GreenYellow;
            this.textBox7.Location = new System.Drawing.Point(50, 44);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 17;
            this.textBox7.Text = "Тема урока";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.GreenYellow;
            this.textBox8.Location = new System.Drawing.Point(50, 12);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 16;
            this.textBox8.Text = "Название урока";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LessonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.lessonTeacher);
            this.Controls.Add(this.lessonDate);
            this.Controls.Add(this.lessonTheme);
            this.Controls.Add(this.lessonName);
            this.Controls.Add(this.lessonInfoGrid);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addGradeButton);
            this.Name = "LessonInfo";
            this.Text = "Урок";
            this.Load += new System.EventHandler(this.LessonInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lessonInfoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button addGradeButton;
        private System.Windows.Forms.DataGridView lessonInfoGrid;
        private System.Windows.Forms.TextBox lessonTeacher;
        private System.Windows.Forms.TextBox lessonDate;
        private System.Windows.Forms.TextBox lessonTheme;
        private System.Windows.Forms.TextBox lessonName;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
    }
}