/*
 * Student ID: 5262256
 * Program: 1
 * Due date: 9/23/24
 * Course Section: CIS-200-75-4248
*/
namespace Prog2Start
{
    public partial class FurnitureForm : Form
    {
        public FurnitureForm()
        {
            InitializeComponent();

            //Testing purposes
            //furnListView.Items.Add(new ListViewItem(["Test1", "Test2", "Test3"]));
        }

        private void FurnitureForm_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show message box with information about program
            MessageBox.Show("Student ID: 5262256\nProgram: 1\nDue date: 9/23/24\nCourse Section: CIS-200-75-4248");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }

        private void couchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open the couch form
            CouchForm couchForm = new CouchForm();

            //When couch form closes, save the dialogresult
            DialogResult couchResult = couchForm.ShowDialog();

            if(couchResult == DialogResult.OK)
            {//If dialogresult is OK (all values were validated)...
                //Add the couch to the listview
                string furnType = "Couch";
                string weight = couchForm.Couch.Weight.ToString();
                string category = couchForm.Couch.Category;
                furnListView.Items.Add(new ListViewItem([furnType, weight, category]));
            } else
            {//If dialogresult is not OK (clicked X button)...
                MessageBox.Show("Couch Form Cancelled."); //Show message about it being cancelled
            }
        }

        private void deskChairToolStripMenuItem_Click (object sender, EventArgs e)
        {
            //Open the deskchair form
            DeskChairForm deskChairForm = new DeskChairForm();

            //When deskchair form closes, save the dialogresult
            DialogResult deskChairResult = deskChairForm.ShowDialog();

            if (deskChairResult == DialogResult.OK)
            {//If dialogresult is OK (all values were validated)...
                //Add the deskchair to the listview
                string furnType = "Desk Chair";
                string weight = deskChairForm.DeskChair.Weight.ToString();
                string category = deskChairForm.DeskChair.Category;
                furnListView.Items.Add(new ListViewItem([furnType, weight, category]));
            }
            else
            {//If dialogresult is not OK (clicked X button)...
                MessageBox.Show("DeskChair Form Cancelled."); //Show message about it being cancelled
            }
        }

        private void detailButton_Click(object sender, EventArgs e)
        {
            if(furnListView.SelectedItems.Count > 0)
            {//If the listview has a selected item... (Note: Only one can be selected at maximum)
                //Show message box information of the selected item
                MessageBox.Show(furnListView.SelectedItems.ToString());
            }
        }
    }
}
