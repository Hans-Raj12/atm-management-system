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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjectDatabase;Integrated Security=True;Connect Timeout=30");
        String Acc = Login.AccNumber;
        private void addTransction()
        {
            String TrType = "Deposit";
            try
            {
                conn.Open();
                String Query = "insert into TransctionTbl values('" +Acc+ "', '"  +TrType+ "', '" +tbDep.Text + "', '"+DateTime.Today.ToString()+"')";
                SqlCommand cmd = new SqlCommand(Query,conn);
                cmd.ExecuteNonQuery();
             //   MessageBox.Show("Account created sucessfully");
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
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if(tbDep.Text == " " || Convert.ToInt32 (tbDep.Text) <= 0)
            {
                MessageBox.Show("Enter Amount for Deposit");
            }
            else
            {
                
                newBalance = prevBalance + Convert.ToInt32(tbDep.Text);
                
                try
                {
                    conn.Open();
                    String Query = "update AccountTbl set Balance =" +newBalance+ "  where AccNum = '"+Acc+"';";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sucessfully Deposit");
                    conn.Close();
                    addTransction();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lbBack_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();

        }
        int prevBalance, newBalance;
        private void getbalance()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select balance from AccountTbl where AccNum = '" + Acc + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            prevBalance = Convert.ToInt32 (dt.Rows[0][0].ToString());
            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            getbalance();
        }
    }
}
