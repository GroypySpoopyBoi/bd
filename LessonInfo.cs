using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace it_s_base
{
    public partial class LessonInfo : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter adapter = null;
        private int lessonId;

        public LessonInfo()
        {
            adapter = new SqlDataAdapter();
            InitializeComponent();
        }

        private void LessonInfo_Load(object sender, EventArgs e)
        {
            SetLessonData();
            lessonInfoGrid.AutoResizeColumns();
        }

        public void SetSQLConnection(SqlConnection sqlConnection)
        {
            this.sqlConnection = sqlConnection;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void SetLessonInfo(string lessonName, string lessonTheme, string lessonDate, string lessonTeacher, int id)
        {
            this.lessonName.Text = lessonName;
            this.lessonTheme.Text = lessonTheme;
            this.lessonDate.Text = lessonDate;
            this.lessonTeacher.Text = lessonTeacher;
            lessonId = id;
        }

        private void SetLessonData()
        {
            var inquiry = "Select " +
                "txtPupilSurname as 'Фамилия ученика', " +
                "txtPupilName as 'Имя ученика', " +
                "datBirthday as 'День рождения ученика', " +
                "intMarkValue as 'Оценка', +" +
                "txtMarkComment as 'Замечание' " +
                "From tblPupil, tblMark " +
                "Where (tblPupil.intPupilId = tblMark.intPupilId) and " +
                "(tblMark.intLessonId = " + lessonId.ToString() + ")";
            DataTable table = new DataTable();
            adapter.SelectCommand = new SqlCommand(inquiry, sqlConnection);

            adapter.Fill(table);
            lessonInfoGrid.DataSource = table;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            SetLessonData();
            lessonInfoGrid.AutoResizeColumns();
            MessageBox.Show("Данные были обновлены");
        }

        private void addGradeButton_Click(object sender, EventArgs e)
        {
            NewMark newMark = new NewMark();

            newMark.SetSQLConnection(sqlConnection);
            newMark.SetLessonData(lessonName.Text, lessonTheme.Text, lessonDate.Text, lessonId);
            newMark.Show();
        }
    }
}
