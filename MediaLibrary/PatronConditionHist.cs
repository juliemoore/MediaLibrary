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
    public partial class PatronConditionHist : Form
    {
        public PatronConditionHist()
        {
            InitializeComponent();
        }

        private void PatronConditionHist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MediaLibraryDataSet.PatronConditionView' table. You can move, or remove it, as needed.
            this.PatronConditionViewTableAdapter.Fill(this.MediaLibraryDataSet.PatronConditionView);

            this.reportViewer1.RefreshReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
