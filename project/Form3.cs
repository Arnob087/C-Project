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
using Dapper;


namespace project
{
    public partial class loginpage : Form
    {
        public loginpage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=user;Integrated Security=True");
        
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void passcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (passcheck.Checked == false)
            {
                passbox.UseSystemPasswordChar = true;
            }
            else
            {
                passbox.UseSystemPasswordChar = false;
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit","confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            signuppage signuppage = new signuppage();
            signuppage.Show();
            this.Hide();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            String username, password;



            username = usertext.Text;
            password = passbox.Text;



            try
            {
                String querry = "SELECT * FROM [User] WHERE Uusername= '" + usertext.Text + "'AND Upassword='" + passbox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con);



                DataTable dt = new DataTable();
                sda.Fill(dt);



                if (dt.Rows.Count > 0)
                {
                    username = usertext.Text;
                    password = passbox.Text;

                    string qr = "Select Title From [User] where Uusername='" + username + "'";

                    con.Open();
                    string x = con.QueryFirstOrDefault<string>(qr);

                    if (x == null)
                    {

                        userpage form2 = new userpage(username, password);
                        form2.Show();
                        this.Hide();



                    }
                    else
                    {
                        //ADD ADMIN PAGE......

                    }
                    con.Close();




                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usertext.Clear();
                    passbox.Clear();



                    usertext.Focus();
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error");
            }
            finally
            {
                con.Close();
            }


        }

    }

}

