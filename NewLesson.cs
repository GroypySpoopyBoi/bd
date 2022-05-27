using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace it_s_base
{
    public partial class NewLesson : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter adapter = null;
        public NewLesson()
        {
            adapter = new SqlDataAdapter();
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void NewLesson_Load(object sender, EventArgs e)
        {
            adapter.SelectCommand = new SqlCommand("Select txtSubjectName From tblSubject", sqlConnection);
            DataTable table = new DataTable();

            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
                LessonBox.Items.Add(table.Rows[i][0].ToString());
        }

        public void SetSQLConnection(SqlConnection sqlConnection)
        {
            this.sqlConnection = sqlConnection;
        }

        private void AddLessonButton_Click(object sender, EventArgs e)
        {
            if (!(LessonBox.SelectedItem != null && Date.Text != "" && Theme.Text != ""))
            {
                MessageBox.Show("Все поля должны быть заполнены!");
                return;
            }

            AddLesson();

            MessageBox.Show("Значение было добавлено");
            LessonBox.SelectedItem = null;
            Date.Text = "";
            Theme.Text = "";
        }

        private string GetSubjectId(string subjectName)
        {
            DataTable table = new DataTable();
            var inquiry = "Select intSubjectId From tblSubject Where txtSubjectName = '" + subjectName + "'";
            adapter.SelectCommand = new SqlCommand(inquiry, sqlConnection);

            adapter.Fill(table);
            return table.Rows[0][0].ToString();
        }

        private void AddLesson()
        {
            DataTable table = new DataTable();
            var subjectId = GetSubjectId(LessonBox.SelectedItem.ToString());
            var inquiry = "Insert Into tblLesson Values (" + subjectId + ", '" + Date.Text + "', '" + Theme.Text + "')";
            adapter.SelectCommand = new SqlCommand(inquiry, sqlConnection);

            adapter.Fill(table);
            adapter.Update(table);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
