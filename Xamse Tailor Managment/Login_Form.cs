using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xamse_Tailor_Managment
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (gunaTextBox2.Text == "admin" && gunaTextBox3.Text == "123")
            {
                Dashboard dd = new Dashboard();
                dd.Show();
            }
            else
            {

                MessageBox.Show("incorect password", "iska sax password-ka", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}
