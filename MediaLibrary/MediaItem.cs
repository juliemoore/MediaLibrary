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
    public partial class MediaItem : Form
    {
        public MediaItem()
        {
            InitializeComponent();
        }

        private void mediaItemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mediaItemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mediaLibraryDataSet);

        }

        private void MediaItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mediaLibraryDataSet.Condition' table. You can move, or remove it, as needed.
            this.conditionTableAdapter.Fill(this.mediaLibraryDataSet.Condition);
            // TODO: This line of code loads data into the 'mediaLibraryDataSet.MediaTitle' table. You can move, or remove it, as needed.
            this.mediaTitleTableAdapter.Fill(this.mediaLibraryDataSet.MediaTitle);
            // TODO: This line of code loads data into the 'mediaLibraryDataSet.MediaItem' table. You can move, or remove it, as needed.
            this.mediaItemTableAdapter.Fill(this.mediaLibraryDataSet.MediaItem);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
