using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sahil_project
{
    public partial class hello : Form
    {
        public hello()
        {
            InitializeComponent();
        }

        private void Hello_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btngo_Click(object sender, EventArgs e)
        {
            lbloutput.Text = "Hi World!!!";
            listBox1.Items = "hlo sir!!!";
        }
    }
}
