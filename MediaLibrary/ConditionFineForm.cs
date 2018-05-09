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
    public partial class ConditionFineForm : Form
    {
        public ConditionFineForm()
        {
            InitializeComponent();
        }

        private void ConditionFineForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mediaLibraryDataSet.DamageFeeView' table. You can move, or remove it, as needed.
            this.damageFeeViewTableAdapter.Fill(this.mediaLibraryDataSet.DamageFeeView);

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance o the DetailsForm
            DamageFeeDetails feeDetails = new DamageFeeDetails();

            // Display the form
            feeDetails.ShowDialog();

            // Update the dataset
            this.damageFeeViewTableAdapter.Fill(this.mediaLibraryDataSet.DamageFeeView);
        }
    }
}
