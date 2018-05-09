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
    public partial class OutstandingItems : Form
    {
        public OutstandingItems()
        {
            InitializeComponent();
        }

        private void OutstandingItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MediaLibraryDataSet.PatronCheckouts' table. You can move, or remove it, as needed.
            this.PatronCheckoutsTableAdapter.Fill(this.MediaLibraryDataSet.PatronCheckouts);

            this.reportViewer1.RefreshReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
