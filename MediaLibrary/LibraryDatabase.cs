using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace MediaLibrary
{
    public partial class LibraryDatabase : Form
    {
        //private object detailsForm;

        public LibraryDatabase()
        {
            InitializeComponent();
        }

        private void LibraryDatabase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mediaLibraryDataSet.Patrons' table. You can move, or remove it, as needed.
            this.patronsTableAdapter.Fill(this.mediaLibraryDataSet.Patrons);
            // TODO: This line of code loads data into the 'mediaLibraryDataSet.PatronCheckouts' table. You can move, or remove it, as needed.
            this.patronCheckoutsTableAdapter.Fill(this.mediaLibraryDataSet.PatronCheckouts);

        }

        private void btnMediaType_Click(object sender, EventArgs e)
        {
            MediaType mediaForm = new MediaType();

            mediaForm.ShowDialog();
        }
        private void btnMediaTitle_Click(object sender, EventArgs e)
        {
            MediaTitle mediaTitleForm = new MediaTitle();

            mediaTitleForm.ShowDialog();
        }

        private void btnMediaItem_Click(object sender, EventArgs e)
        {
            MediaItem mediaItemForm = new MediaItem();

            mediaItemForm.ShowDialog();
        }

        private void btnCondition_Click(object sender, EventArgs e)
        {
            Condition conditionForm = new Condition();

            conditionForm.ShowDialog();
        }

        private void btnPatrons_Click(object sender, EventArgs e)
        {
            Patrons patronForm = new Patrons();

            patronForm.ShowDialog();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Checkout checkoutForm = new Checkout();

            checkoutForm.ShowDialog();
        }

        private void bntFines_Click(object sender, EventArgs e)
        {
            Fines finesForm = new Fines();

            finesForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void btnOutstandingFines_Click(object sender, EventArgs e)
        {
            // Create an instance o the DetailsForm
            DetailsForm details = new DetailsForm();

            // Display the form
            details.ShowDialog();

            // Update the dataset
            this.patronCheckoutsTableAdapter.Fill(this.mediaLibraryDataSet.PatronCheckouts);
        }

        private void btnOutstandingItems_Click(object sender, EventArgs e)
        {
            // Create an instance of the Outstnding Items form 
            OverdueForm overdue = new OverdueForm();

            // Display the form
            overdue.ShowDialog();

            // Update the dataset
            this.patronCheckoutsTableAdapter.FillByOverDue(this.mediaLibraryDataSet.PatronCheckouts);
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            // Create an instance o the DetailsForm
            Details details = new Details();

            // Display the form
            details.ShowDialog();

            // Update the dataset
            this.patronCheckoutsTableAdapter.Fill(this.mediaLibraryDataSet.PatronCheckouts);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.patronsTableAdapter.SearchLastName(this.mediaLibraryDataSet.Patrons, searchTextBox.Text);
        }

        private void btnConditionFines_Click(object sender, EventArgs e)
        {
            // Create an instance of the Condition Fine Form
            ConditionFineForm fineForm = new ConditionFineForm();


            // Display the form
            fineForm.ShowDialog();

            // Update the dataset
            this.patronCheckoutsTableAdapter.Fill(this.mediaLibraryDataSet.PatronCheckouts);
        }

        private void btnCheckOutHist_Click(object sender, EventArgs e)
        {
            OutstandingItems outstandingItemsForm = new OutstandingItems();

            outstandingItemsForm.ShowDialog();
        }

        private void btnPatronConditionHist_Click(object sender, EventArgs e)
        {
            PatronConditionHist patronConditionHistForm = new PatronConditionHist();
            patronConditionHistForm.ShowDialog();
        }

        private void btnConditionFinesHist_Click(object sender, EventArgs e)
        {
            ConditionFinesHist conditionFinesHistForm = new ConditionFinesHist();
            conditionFinesHistForm.ShowDialog();
        }
    }
}
