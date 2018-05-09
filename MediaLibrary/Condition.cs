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
    public partial class Condition : Form
    {
        public Condition()
        {
            InitializeComponent();
        }

        private void conditionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.conditionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mediaLibraryDataSet);

        }

        private void Condition_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mediaLibraryDataSet.Condition' table. You can move, or remove it, as needed.
            this.conditionTableAdapter.Fill(this.mediaLibraryDataSet.Condition);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
