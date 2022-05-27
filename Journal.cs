using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace it_s_base
{
    public partial class Journal : Form
    {
        private string subject;
        public Journal()
        {
            InitializeComponent();
        }

        public void setSubject(string value)
        {
            subject = value;
        }

        private void Journal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.dataJournal". При необходимости она может быть перемещена или удалена.
            this.dataJournalTableAdapter.Fill(this.testDataSet.dataJournal, subject);

            this.reportViewer1.RefreshReport();
        }
    }
}
