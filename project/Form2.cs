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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace project
{
    public partial class signuppage : Form
    {
        public signuppage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=user;Integrated Security=True");

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked == false)
            {
                passbox.UseSystemPasswordChar = true;
            }
            else
            {
                passbox.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (namebox.Text == "" || addressbox.Text == "" || numberbox.Text == "" || mailbox.Text == "" || usernamebox.Text == "" || passbox.Text == "")
            {
                MessageBox.Show("Please fill all the information box in a correct way");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO [User](Uname, Uaddress, Unumber, Uemail, Uusername, Upassword) VALUES('" + namebox.Text + "','" + addressbox.Text + "','" + numberbox.Text + "','" + mailbox.Text + "','" + usernamebox.Text + "','" + passbox.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thank You for signing up. Please Log In");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();

                loginpage loginpage = new loginpage();
                loginpage.Show();
                this.Hide();
            }


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            loginpage loginpage = new loginpage();
            loginpage.Show();
            this.Hide();
        }
    }
}
