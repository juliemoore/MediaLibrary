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
    public partial class Patrons : Form
    {
        public Patrons()
        {
            InitializeComponent();
        }

        private void patronsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patronsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mediaLibraryDataSet);

        }

        private void patronsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.patronsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mediaLibraryDataSet);

        }

        private void Patrons_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mediaLibraryDataSet.Patrons' table. You can move, or remove it, as needed.
            this.patronsTableAdapter.Fill(this.mediaLibraryDataSet.Patrons);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
