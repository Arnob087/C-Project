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
    public partial class userpage : Form
    {
        string uname, upass;
        
        public userpage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=user;Integrated Security=True");
        public userpage(string x, string y)
        {
            InitializeComponent();
            this.uname= x;
            this.upass= y;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string querry = "Select Status From [User] where Uusername='" + uname + "'";

            con.Open();
            string x = con.QueryFirstOrDefault<string>(querry);

            if (x == null)
            {
                MessageBox.Show("You are not able to post. Please pay first.");

                Paymentpage Paymentpage = new Paymentpage(uname, upass);
                Paymentpage.Show();
                this.Hide();


            }
            else
            {

                exchangepage exchangepage = new exchangepage(uname, upass, textBox2.Text);
                exchangepage.Show();
                this.Hide();

                
                //HERE WILL BE THE CODE OF "EXCHANGE/BUY" BUTTON;



            }
            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            productdetailpage productdetailpage = new productdetailpage(uname, upass, textBox2.Text);
            productdetailpage.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            

        }

        private void button6_Click(object sender, EventArgs e)
        {


            SqlCommand cmd = new SqlCommand("SELECT DID AS Device_ID, Dname AS Device_Name,ExchangeWith AS Exchange_With from [Deviceinfo]", con);
            DataTable dt = new DataTable();



            con.Open();



            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           ///StudentID.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT DID,Dname,ExchangeWith FROM [DeviceInfo] WHERE Dname='" + textBox1.Text + "' AND ExchangeWith='" + textBox1.Text + "'", con);
                DataTable dt = new DataTable();



                con.Open();



                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                con.Close();
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            string querry = "Select Status From [User] where Uusername='"+uname+"'";

            con.Open();
            string x = con.QueryFirstOrDefault<string>(querry);
           
            if (x == null)
            {
                MessageBox.Show("You are not able to post. Please pay first.");

                Paymentpage Paymentpage = new Paymentpage(uname, upass);
                Paymentpage.Show();
                this.Hide();

                
            }
            else
            {
                postpage postpage = new postpage(uname, upass);
                postpage.Show();
                this.Hide();

            }
            con.Close();

        }
    }
}
