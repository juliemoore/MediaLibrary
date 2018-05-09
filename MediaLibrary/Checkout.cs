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
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
        }

        private void checkoutBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.checkoutBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mediaLibraryDataSet);

        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mediaLibraryDataSet.Condition' table. You can move, or remove it, as needed.
            this.conditionTableAdapter.Fill(this.mediaLibraryDataSet.Condition);
            // TODO: This line of code loads data into the 'mediaLibraryDataSet.Patrons' table. You can move, or remove it, as needed.
            this.patronsTableAdapter.Fill(this.mediaLibraryDataSet.Patrons);
            // TODO: This line of code loads data into the 'mediaLibraryDataSet.MediaItem' table. You can move, or remove it, as needed.
            this.mediaItemTableAdapter.Fill(this.mediaLibraryDataSet.MediaItem);
            // TODO: This line of code loads data into the 'mediaLibraryDataSet.Checkout' table. You can move, or remove it, as needed.
            this.checkoutTableAdapter.Fill(this.mediaLibraryDataSet.Checkout);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
