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
    public partial class NewMark : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter adapter = null;
        private int lessonId;
        private List<int> pupilId = new List<int>();

        public NewMark()
        {
            adapter = new SqlDataAdapter();
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void SetSQLConnection(SqlConnection sqlConnection)
        {
            this.sqlConnection = sqlConnection;
        }

        public void SetLessonData(string name, string theme, string date, int id)
        {
            lessonDate.Text = date;
            lessonName.Text = name;
            lessonTheme.Text = theme;
            lessonId = id;
        }

        private void NewMark_Load(object sender, EventArgs e)
        {
            SetMarkList();
            SetPupilNameList();
        }

        private void SetMarkList()
        {
            markList.Items.AddRange(new object[] { 1, 2, 3, 4, 5 });
        }

        private void SetPupilNameList()
        {
            DataTable table = new DataTable();
            var injuiry = "Select txtPupilSurname, txtPupilName, intPupilId From tblPupil";
            adapter.SelectCommand = new SqlCommand(injuiry, sqlConnection);

            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                pupilFullNameList.Items.Add(table.Rows[i][0].ToString().Replace(" ", "") + " " + table.Rows[i][1].ToString().Replace(" ", ""));
                pupilId.Add(int.Parse(table.Rows[i][2].ToString()));
            }
        }

        private void AddMarkButton_Click(object sender, EventArgs e)
        {
            if (pupilFullNameList.SelectedItem == null || markList.SelectedItem == null)
            {
                MessageBox.Show("Поля 'ФИО ученика' и 'Оценка' должны быть заполнены");
                return;
            }

            AddMark();
            pupilFullNameList.SelectedItem = null;
            markList.SelectedItem = null;
            markComment.Text = "";
            MessageBox.Show("Оценка добавлена");
        }

        private void AddMark()
        {
            int selecteedIndex = int.Parse(pupilFullNameList.SelectedIndex.ToString());
            DataTable table = new DataTable();
            var inquiry = "Insert Into tblMark Values (" +
                lessonId.ToString() + ", " +
                pupilId[selecteedIndex].ToString() + ", " +
                markList.SelectedItem.ToString() + ", '" +
                markComment.Text + "')";
            adapter.SelectCommand = new SqlCommand(inquiry, sqlConnection);

            adapter.Fill(table);
            adapter.Update(table);
        }
    }
}
