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

namespace Project
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjectDatabase;Integrated Security=True;Connect Timeout=30");
        private void btnLog_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if(tbAcc.Text == " " || tbName.Text == " " || tbFName.Text == " " || tbPhone.Text == " " || tbAdd.Text == " " || tbOcc.Text == " " || tbPin.Text == " ")
            {
                MessageBox.Show("Missing Info");
            }
            else
            {
                try
                {

                    int pin = int.Parse(tbPin.Text);
                   conn.Open();
                    String Query = "insert into AccountTbl values('"+tbAcc.Text+"', '"+tbName.Text+"', '"+tbFName.Text+"', '"+tbAdd.Text+"', '"+tbPhone.Text+"', '"+cbEdu.SelectedItem.ToString()+"', "+pin+", '"+tbOcc.Text+"', '"+ dateTimePicker1.Value.Date + "', "+bal+");";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account created sucessfully");
                    conn.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
