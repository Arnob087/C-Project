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
    public partial class Paymentpage : Form
    {
        string uname, upass;
        public Paymentpage()
        {
            InitializeComponent();
        }

        public Paymentpage(string x, string y)
        {
            this.uname = x;
            this.upass = y;
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=user;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            if (amount.Text == "")
            {
                MessageBox.Show("Please enter the amount you want to pay");
            }
            else
            {

                int a = Convert.ToInt32(amount.Text);

                if (a == 100)
                {
                    if (usernamebox.Text == uname && passbox.Text == upass)
                    {

                        try
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("UPDATE [User] SET Status='Valid' WHERE Uusername='" + usernamebox.Text + "'", con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Thank You for paying. Enjoy your journey with us.");

                            userpage userpage = new userpage(uname, upass);
                            userpage.Show();
                            this.Hide();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your Username OR Password is not Correct");
                        usernamebox.Clear();
                        passbox.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Please Pay 100TK. You  must have to pay 100.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userpage userpage = new userpage(uname, upass);
            userpage.Show();
            this.Hide();
        }
    }
}
