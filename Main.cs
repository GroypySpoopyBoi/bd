using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace it_s_base
{
    public partial class Main : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter adapter = null;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            adapter = new SqlDataAdapter();

            sqlConnection.Open();

            DataTable table = new DataTable();
            var injuiry = "Select txtSubjectName From tblSubject";
            adapter.SelectCommand = new SqlCommand(injuiry, sqlConnection);

            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                subjectBox.Items.Add(table.Rows[i][0].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lesson = new Lessons();
            lesson.SetSQLConnection(sqlConnection);
            lesson.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var teacher = new Teachers();
            teacher.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var pupil = new Pupil();
            pupil.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var journal = new Journal();
            journal.setSubject(subjectBox.SelectedItem.ToString());
            journal.Show();
        }
    }
}
