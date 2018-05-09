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
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        private void Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mediaLibraryDataSet.PatronCheckouts' table. You can move, or remove it, as needed.
            this.patronCheckoutsTableAdapter.Fill(this.mediaLibraryDataSet.PatronCheckouts);
            // TODO: This line of code loads data into the 'mediaLibraryDataSet.PatronCheckouts' table. You can move, or remove it, as needed.
            this.patronCheckoutsTableAdapter.Fill(this.mediaLibraryDataSet.PatronCheckouts);

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
