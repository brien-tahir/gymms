using System.Configuration;
using System.Security.Cryptography;
using System.Windows.Forms;
using gymms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gymms
{
    public partial class Form1 : Form
    {
        MyConfig objconfig = new MyConfig();
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);  // Optionally, make the tabs almost invisible
            tabControl1.SizeMode = TabSizeMode.Fixed;



            objconfig.RetrieveData(userDataGridView);







        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtUserID.Text, out id))
            {
                // Successfully converted textBox1.Text to an integer for id.
                objconfig.UserDelete(id);
                objconfig.RetrieveData(userDataGridView);
                txtFullname.Clear();
                txtUname.Clear();
                txtUpass.Clear();
            }
            else
            {
                MessageBox.Show("Invalid input for ID ");
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUserInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullname.Text) || txtFullname.Text == "Fullname" || txtUname.Text == "Username" || txtUpass.Text == "Password" || string.IsNullOrWhiteSpace(txtUname.Text) || string.IsNullOrWhiteSpace(txtUpass.Text))
            {
                MessageBox.Show("Please fill in both fields.");
            }
            else
            {
                DateTime userRegDates = userRegDate.Value;

                objconfig.userInsert(txtFullname.Text, txtUname.Text, txtUpass.Text, userRegDates);
                txtFullname.Clear();
                txtUname.Clear();
                txtUpass.Clear();


                //Retrieve data from database and display
                objconfig.RetrieveData(userDataGridView);

            }

        }

        private void userDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txtUserID.Text = this.userDataGridView.CurrentRow.Cells[0].Value.ToString();
            txtFullname.Text = this.userDataGridView.CurrentRow.Cells[1].Value.ToString();
            txtUname.Text = this.userDataGridView.CurrentRow.Cells[2].Value.ToString();
            txtUpass.Text = this.userDataGridView.CurrentRow.Cells[3].Value.ToString();
            userRegDate.Text = this.userDataGridView.CurrentRow.Cells[4].Value.ToString();


        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            DateTime userdate=userRegDate.Value;
            string fname = txtFullname.Text;
            string uname = txtUname.Text;
            string upass = txtUpass.Text;
            int userID;


            // No need to convert, as it's already a string.
            if (int.TryParse(txtUserID.Text, out userID))
            {
                // Successfully converted textBox1.Text to an integer for id.
                objconfig.UserUpdate(userID,fname, uname, upass, userdate);
                txtFullname.Clear();
                txtUname.Clear();
                txtUpass.Clear();

                objconfig.RetrieveData(userDataGridView);

            }
            else
            {
                MessageBox.Show("Invalid input for ID or age.");
            }
        }
    }
}
