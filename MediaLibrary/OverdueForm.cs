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
    public partial class OverdueForm : Form
    {
        public OverdueForm()
        {
            InitializeComponent();
        }

        private void OverdueForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mediaLibraryDataSet.PatronCheckouts' table. You can move, or remove it, as needed.
            this.patronCheckoutsTableAdapter.Fill(this.mediaLibraryDataSet.PatronCheckouts);

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
