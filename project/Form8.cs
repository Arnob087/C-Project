using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class exchangepage : Form
    {
        string uname, upass, productID;
        public exchangepage()
        {
            InitializeComponent();
        }

        public exchangepage(string x, string y, string z)
        {
            this.uname = x;
            this.upass = y;
            this.productID = z;
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=user;Integrated Security=True");


        private void exchangepage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Uname, Uaddress,Unumber, Uemail from [User] WHERE Uname= (Select Username FROM [DeviceInfo] WHERE DID='" + productID + "' )", con);
                DataTable dt = new DataTable();



                con.Open();



                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                con.Close();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userpage userpage = new userpage(uname, upass);
            userpage.Show();
            this.Hide();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you contact with the exchanger ?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MessageBox.Show("Do you exchanging with the exchanger ?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Thank you for using our APP. Happy Exchange.");
                    userpage userpage = new userpage(uname, upass);
                    userpage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please exchange or go back for more exchange option.");
                }
                
            }
            else
            {
                MessageBox.Show("Please contact with the exchanger at first.");
                this.Show();
            }
        }
    }
}
