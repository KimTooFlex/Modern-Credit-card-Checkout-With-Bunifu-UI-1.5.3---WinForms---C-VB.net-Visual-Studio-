using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Payment_Checkout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            bunifuCheckbox1.Checked = bunifuCheckbox2.Checked = bunifuCheckbox3.Checked = false;
            ((Bunifu.Framework.UI.BunifuCheckbox)sender).Checked = true;
        }

        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {
            bunifuCheckbox1.Checked = bunifuCheckbox2.Checked = bunifuCheckbox3.Checked = false;
            ((Bunifu.Framework.UI.BunifuCheckbox)sender).Checked = true;
        }

        private void bunifuCheckbox3_OnChange(object sender, EventArgs e)
        {
            bunifuCheckbox1.Checked = bunifuCheckbox2.Checked = bunifuCheckbox3.Checked = false;
            ((Bunifu.Framework.UI.BunifuCheckbox)sender).Checked = true;
        }
    }
}
