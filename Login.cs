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
using System.Configuration;
using System.Data.Common;


namespace Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       

        private void label5_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.Show();
            this.Hide();
        }
        public static String AccNumber;
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjectDatabase;Integrated Security=True;Connect Timeout=30");



        private void btnLog_Click(object sender, EventArgs e)
        {
            AccNumber = this.tbAcc.Text;
            int pin = int.Parse(this.tbPin.Text);
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "select * from AccountTbl where AccNum = '" + AccNumber + "' and Pin=" + pin + ";";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    AccNumber = tbAcc.Text;
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }


                else
                {
                    MessageBox.Show("Incorrect Account Number or Pin Code");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
