using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace it_s_base
{
    public partial class Lessons : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;
        public Lessons()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter();

            UpdateLessonData();
            dataGridViewLesson.AutoResizeColumns();
        }



        private void AddLessonButton_Click(object sender, EventArgs e)
        {
            NewLesson newLessonForm = new NewLesson();
            newLessonForm.Location = AddLessonButton.Location;
            newLessonForm.SetSQLConnection(sqlConnection);
            newLessonForm.Show();
        }

        private void UpdateLessonData()
        {
            table = new DataTable();
            string inquiry = "Select " +
                "txtSubjectName as 'Название урока', " +
                "datLessonDate as 'Дата проведения урока', " +
                "txtTheme as 'Тема урока', " +
                "txtTeacherName as 'ФИО преподавателя' " +
                "FROM tblLesson, tblTeacher, tblSubject " +
                "WHERE(tblLesson.intSubjectId = tblSubject.intSubjectId) and(tblSubject.intTeacherId = tblTeacher.intTeacherId)";
            adapter.SelectCommand = new SqlCommand(inquiry, sqlConnection);

            adapter.Fill(table);
            dataGridViewLesson.DataSource = table;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateLessonData();
            MessageBox.Show("Данные были обновлены");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void SetSQLConnection(SqlConnection sqlConnection)
        {
            this.sqlConnection = sqlConnection;
        }

        private void dataGridViewLesson_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 2 || e.RowIndex == -1)
                return;

            var lessonInfo = new LessonInfo();
            lessonInfo.SetSQLConnection(sqlConnection);
            var lessonName = table.Rows[e.RowIndex][0].ToString();
            var lessonTheme = table.Rows[e.RowIndex][2].ToString();
            var lessonDate = table.Rows[e.RowIndex][1].ToString();
            var lessonTeacher = table.Rows[e.RowIndex][3].ToString();

            lessonDate = lessonDate.Substring(0, 8);
            lessonInfo.SetLessonInfo(lessonName, lessonTheme, lessonDate, lessonTeacher, e.RowIndex+1);
            lessonInfo.Show();
        }

        private void dataGridViewLesson_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}