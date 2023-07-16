using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void btnBal_Click(object sender, EventArgs e)
        {
            Balance bal = new Balance();
            bal.Show();
            this.Hide();
            
        }
        public static String AccNumber;
        private void HOME_Load(object sender, EventArgs e)
        {
            AccNumlb.Text = "Account Number:" + Login.AccNumber;
            AccNumber = Login.AccNumber;
        }

        private void btnDep_Click(object sender, EventArgs e)
        {
            Deposit dep = new Deposit();
            dep.Show();
            this.Hide();
        }

        private void btnCP_Click(object sender, EventArgs e)
        {
            ChangePin pin = new ChangePin();
            pin.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWD_Click(object sender, EventArgs e)
        {
            Withdraw wd = new Withdraw();
            wd.Show();
            this.Hide();
        }

        private void btnFC_Click(object sender, EventArgs e)
        {
            FastCash fc = new FastCash();
            fc.Show();
            this.Hide();
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            MiniStatement ms = new MiniStatement();
            ms.Show();
            this.Hide();
        }
    }
}
