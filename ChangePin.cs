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
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjectDatabase;Integrated Security=True;Connect Timeout=30");
        String Acc = Login.AccNumber;

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (tbPin1.Text == "" || tbPin2.Text == "")
            {
                MessageBox.Show("Enter and Confirm New Pin");
            }
            else if (tbPin2.Text != tbPin1.Text)
            {
                MessageBox.Show("mis Matched");
            }
            else
            {
                try
                {
                    conn.Open();
                    String Query = "update AccountTbl set Pin =" + tbPin1.Text + "  where AccNum = '" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Pin Sucessfully changed");
                    conn.Close();
                    Login home = new Login();
                    home.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lbBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbLOut_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();

        }
    }
}