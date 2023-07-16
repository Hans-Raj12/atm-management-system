using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjectDatabase;Integrated Security=True;Connect Timeout=30");

        private void getbalance()
        {
           
             conn.Open();
             SqlDataAdapter sda = new SqlDataAdapter("select balance from AccountTbl where AccNum = '" + lbAccNum.Text + "'", conn);
             DataTable dt = new DataTable();
             sda.Fill(dt);
             lbBalance.Text = "Rs " + dt.Rows[0][0].ToString();

             conn.Close();
           
        }
        private void Balance_Load(object sender, EventArgs e)
        {
            lbAccNum.Text = HOME.AccNumber;
            getbalance();
        }

        private void lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbBack_Click(object sender, EventArgs e)
        {
            HOME home  = new HOME();
            this.Hide();
            home.Show();
        }

       
    }
}
