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
    public partial class PatronCheckouts : Form
    {
        public PatronCheckouts()
        {
            InitializeComponent();
        }

        private void PatronCheckouts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mediaLibraryDataSet.PatronCheckouts' table. You can move, or remove it, as needed.
            this.patronCheckoutsTableAdapter.Fill(this.mediaLibraryDataSet.PatronCheckouts);

        }
    }
}
