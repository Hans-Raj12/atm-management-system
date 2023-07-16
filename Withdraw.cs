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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjectDatabase;Integrated Security=True;Connect Timeout=30");
        String Acc = Login.AccNumber;
        int bal;
        private void getbalance()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select balance from AccountTbl where AccNum = '" + Acc + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lbAvBal.Text = "Balance Rs " + dt.Rows[0][0].ToString();
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            conn.Close();
        }
        private void addTransction()
        {
            String TrType = "WithDraw";
            try
            {
                conn.Open();
                String Query = "insert into TransctionTbl values('" + Acc + "', '" + TrType + "', '" + tbWdAmount.Text + "', '" + DateTime.Today.ToString() + "')";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                Login log = new Login();
                log.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            getbalance();
        }

       
        int newBalance;


       

        private void btnWDraw_Click_1(object sender, EventArgs e)
        {
            if (tbWdAmount.Text == " ")
            {
                MessageBox.Show("Missing Info");
            }
            else if (Convert.ToInt32(tbWdAmount.Text) <= 0)
            {
                MessageBox.Show("Enter the valid Amount");
            }
            else if (Convert.ToInt32(tbWdAmount.Text) > bal)
            {
                MessageBox.Show("Balance can't be negative");
            }
            else
            {
                newBalance = bal - Convert.ToInt32(tbWdAmount.Text);
                try
                {
                    conn.Open();
                    String Query = "update AccountTbl set Balance =" + newBalance + "  where AccNum = '" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sucessfully Withdraw");
                    conn.Close();
                    addTransction();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void lb2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HOME home = new HOME();
            home.Show();

        }
    }
}