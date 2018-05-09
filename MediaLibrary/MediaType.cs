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
    public partial class MediaType : Form
    {
        public MediaType()
        {
            InitializeComponent();
        }

        private void mediaTypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mediaTypeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mediaLibraryDataSet);

        }

        private void MediaType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mediaLibraryDataSet.MediaType' table. You can move, or remove it, as needed.
            this.mediaTypeTableAdapter.Fill(this.mediaLibraryDataSet.MediaType);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
