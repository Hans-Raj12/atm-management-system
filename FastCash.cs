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
    public partial class FastCash : Form
    {
        public FastCash()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjectDatabase;Integrated Security=True;Connect Timeout=30");
        String Acc = Login.AccNumber;
        private void label2_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }
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
        private void FastCash_Load(object sender, EventArgs e)
        {
            getbalance();
        }
        private void addTransction1()
        {
            String TrType = "WithDraw";
            try
            {
                conn.Open();
                String Query = "insert into TransctionTbl values('" + Acc + "', '" + TrType + "', '" +100+ "', '" + DateTime.Today.ToString() + "')";
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
        private void addTransctio2()
        {
            String TrType = "WithDraw";
            try
            {
                conn.Open();
                String Query = "insert into TransctionTbl values('" + Acc + "', '" + TrType + "', '" + 500 + "', '" + DateTime.Today.ToString() + "')";
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
        private void addTransction3()
        {
            String TrType = "WithDraw";
            try
            {
                conn.Open();
                String Query = "insert into TransctionTbl values('" + Acc + "', '" + TrType + "', '" + 1000 + "', '" + DateTime.Today.ToString() + "')";
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

        private void addTransction4()
        {
            String TrType = "WithDraw";
            try
            {
                conn.Open();
                String Query = "insert into TransctionTbl values('" + Acc + "', '" + TrType + "', '" + 2000 + "', '" + DateTime.Today.ToString() + "')";
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

        private void addTransction5()
        {
            String TrType = "WithDraw";
            try
            {
                conn.Open();
                String Query = "insert into TransctionTbl values('" + Acc + "', '" + TrType + "', '" + 5000 + "', '" + DateTime.Today.ToString() + "')";
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

        private void addTransction6()
        {
            String TrType = "WithDraw";
            try
            {
                conn.Open();
                String Query = "insert into TransctionTbl values('" + Acc + "', '" + TrType + "', '" + 10000 + "', '" + DateTime.Today.ToString() + "')";
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


        private void btnCash1_Click_1(object sender, EventArgs e)
        {
            if(bal < 100)
            {
                MessageBox.Show("balance can't be negative ");
            }
            else
            {
               int  newBalance = bal - 100;
                try
                {
                    conn.Open();
                    String Query = "update AccountTbl set Balance =" + newBalance + "  where AccNum = '" +Acc+ "';";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sucessfully Withdraw");
                    conn.Close();
                    addTransction1();
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

        private void btnCash2_Click_1(object sender, EventArgs e)
        {
            if (bal < 500)
            {
                MessageBox.Show("balance can't be negative ");
            }
            else
            {
                int newBalance = bal - 500;
                try
                {
                    conn.Open();
                    String Query = "update AccountTbl set Balance =" + newBalance + "  where AccNum = '" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sucessfully Withdraw");
                    conn.Close();
                    addTransctio2();
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

        private void btnCash3_Click_1(object sender, EventArgs e)
        {
            if (bal < 1000)
            {
                MessageBox.Show("balance can't be negative ");
            }
            else
            {
                int newBalance = bal - 1000;
                try
                {
                    conn.Open();
                    String Query = "update AccountTbl set Balance =" + newBalance + "  where AccNum = '" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sucessfully Withdraw");
                    conn.Close();
                    addTransction3();
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

        private void btnCash4_Click_1(object sender, EventArgs e)
        {
            if (bal < 2000)
            {
                MessageBox.Show("balance can't be negative ");
            }
            else
            {
                int newBalance = bal - 2000;
                try
                {
                    conn.Open();
                    String Query = "update AccountTbl set Balance =" + newBalance + "  where AccNum = '" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sucessfully Withdraw");
                    conn.Close();
                    addTransction4();
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

        private void btnCash5_Click_1(object sender, EventArgs e)
        {
            if (bal < 5000)
            {
                MessageBox.Show("balance can't be negative ");
            }
            else
            {
                int newBalance = bal - 5000;
                try
                {
                    conn.Open();
                    String Query = "update AccountTbl set Balance =" + newBalance + "  where AccNum = '" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sucessfully Withdraw");
                    conn.Close();
                    addTransction5();
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

        private void btnCash6_Click_1(object sender, EventArgs e)
        {
            if (bal < 10000)
            {
                MessageBox.Show("balance can't be negative ");
            }
            else
            {
                int newBalance = bal - 10000;
                try
                {
                    conn.Open();
                    String Query = "update AccountTbl set Balance =" + newBalance + "  where AccNum = '" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sucessfully Withdraw");
                    conn.Close();
                    addTransction6();
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
    }
}
