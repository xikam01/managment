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
    public partial class Spalash : Form
    {
        public Spalash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            gunaProgressBar1.Increment(3);
            if (gunaProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                Login_Form dd = new Login_Form();
                dd.Show();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
