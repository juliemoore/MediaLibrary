using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaLibrary
{
    public partial class ConditionFinesHist : Form
    {
        public ConditionFinesHist()
        {
            InitializeComponent();
        }

        private void ConditionFinesHist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MediaLibraryDataSet.ConditionFinesView' table. You can move, or remove it, as needed.
            this.ConditionFinesViewTableAdapter.Fill(this.MediaLibraryDataSet.ConditionFinesView);

            this.reportViewer1.RefreshReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
