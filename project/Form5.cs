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
    public partial class postpage : Form
    {
        string uname, upass;
        public postpage()
        {
            
            InitializeComponent();
        }
        public postpage(string x, string y)
        {
            this.uname = x;
            this.upass = y;
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=user;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            //ADD ALL PRODUCT DETAILS IN DATABASE.....

            if (dname.Text == "" || model.Text == "" || condition.Text == "" || exchangewith.Text == "" || price.Text == "" || details.Text == "")
            {
                MessageBox.Show("Please fill all the information box in a correct way");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO [DeviceInfo](Dname, ModelName, DeviceCondition, ExchangeWith, WantedPrice, Details, Username ) VALUES('" + dname.Text + "','" + model.Text + "','" + condition.Text + "','" + exchangewith.Text + "','" + price.Text + "','" + details.Text + "','" + uname + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thank You for posting. ");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally {

                    userpage userpage = new userpage();
                    userpage.Show();
                    this.Hide();
                    con.Close();
                }
                

                
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            userpage userpage = new userpage(uname,upass);
            userpage.Show();
            this.Close();
        }
    }
}
