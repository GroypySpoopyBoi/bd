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
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.dataTeacher". При необходимости она может быть перемещена или удалена.
            this.dataTeacherTableAdapter.Fill(this.testDataSet.dataTeacher);

            this.reportViewer1.RefreshReport();
        }
    }
}
