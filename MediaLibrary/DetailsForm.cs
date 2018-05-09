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
    public partial class DetailsForm : Form
    {
        public DetailsForm()
        {
            InitializeComponent();
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mediaLibraryDataSet.FinesView' table. You can move, or remove it, as needed.
            this.finesViewTableAdapter.Fill(this.mediaLibraryDataSet.FinesView);

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
