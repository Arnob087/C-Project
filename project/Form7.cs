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
    public partial class productdetailpage : Form
    {
        string uname, upass, productID;
        public productdetailpage()
        {
            InitializeComponent();
        }
        public productdetailpage(string x, string y, string z)
        {
            this.uname = x;
            this.upass = y;
            this.productID = z;
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=user;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT DID,ModelName,DeviceCondition,ExchangeWith,WantedPrice,Details FROM [DeviceInfo] WHERE DID='" + productID + "'", con);
                DataTable dt = new DataTable();



                con.Open();



                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
            finally
            { 
                con.Close();
            }
        }

        

        private void signupbtn_Click(object sender, EventArgs e)
        {
            userpage userpage = new userpage(uname, upass);
            userpage.Show();
            this.Hide();
        }
    }
}
