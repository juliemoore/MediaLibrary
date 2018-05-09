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
    public partial class Fines : Form
    {
        public Fines()
        {
            InitializeComponent();
        }

        private void finesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.finesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mediaLibraryDataSet);

        }

        private void Fines_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mediaLibraryDataSet.Fines' table. You can move, or remove it, as needed.
            this.finesTableAdapter.Fill(this.mediaLibraryDataSet.Fines);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
