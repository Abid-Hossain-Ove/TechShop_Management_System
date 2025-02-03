using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechShop_Management_System.FILE
{
    public partial class Forgot_paswd_vdo_3_sujan : Form
    {
        public Forgot_paswd_vdo_3_sujan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if(Username.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter user name .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else if (txtEmail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter user email .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else
            {
                string pass = Computer.Computer.ForgotPassword(txtUsername.Text.Trim());
                if(pass != string.Empty)
                {
                    MessageBox.Show($"Your password is : {pass}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Username of Email is incorrect.", "Information", MessageBoxButtons.OK, MessageBoxButtons.Information);
                }
            }
        }
    }
}
