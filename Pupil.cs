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
    public partial class Pupil : Form
    {
        public Pupil()
        {
            InitializeComponent();
        }

        private void Pupil_Load(object sender, EventArgs e)
        {
            this.dataPupilTableAdapter.Fill(this.testDataSet.dataPupil);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
        }
    }
}
