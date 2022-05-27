
namespace it_s_base
{
    partial class Lessons
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
            this.dataGridViewLesson = new System.Windows.Forms.DataGridView();
            this.AddLessonButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLesson)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLesson
            // 
            this.dataGridViewLesson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLesson.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.dataGridViewLesson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLesson.GridColor = System.Drawing.Color.CadetBlue;
            this.dataGridViewLesson.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLesson.Name = "dataGridViewLesson";
            this.dataGridViewLesson.Size = new System.Drawing.Size(1007, 404);
            this.dataGridViewLesson.TabIndex = 0;
            this.dataGridViewLesson.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLesson_CellContentClick);
            this.dataGridViewLesson.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLesson_CellDoubleClick);
            // 
            // AddLessonButton
            // 
            this.AddLessonButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddLessonButton.BackColor = System.Drawing.Color.Cornsilk;
            this.AddLessonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddLessonButton.ForeColor = System.Drawing.Color.Crimson;
            this.AddLessonButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddLessonButton.Location = new System.Drawing.Point(675, 423);
            this.AddLessonButton.Name = "AddLessonButton";
            this.AddLessonButton.Size = new System.Drawing.Size(320, 49);
            this.AddLessonButton.TabIndex = 1;
            this.AddLessonButton.Text = "Добавить урок";
            this.AddLessonButton.UseVisualStyleBackColor = false;
            this.AddLessonButton.Click += new System.EventHandler(this.AddLessonButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CloseButton.BackColor = System.Drawing.Color.Cornsilk;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.Crimson;
            this.CloseButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CloseButton.Location = new System.Drawing.Point(12, 423);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(320, 49);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UpdateButton.BackColor = System.Drawing.Color.Cornsilk;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateButton.ForeColor = System.Drawing.Color.Crimson;
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UpdateButton.Location = new System.Drawing.Point(343, 423);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(320, 49);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // Lessons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 494);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.AddLessonButton);
            this.Controls.Add(this.dataGridViewLesson);
            this.Name = "Lessons";
            this.Text = "Уроки";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLesson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLesson;
        private System.Windows.Forms.Button AddLessonButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button UpdateButton;
    }
}

