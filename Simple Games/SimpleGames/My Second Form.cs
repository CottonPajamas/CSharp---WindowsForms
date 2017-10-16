using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_UI_1._3a
{
    public partial class My_Second_Form : Form
    {
        public My_Second_Form()
        {
            InitializeComponent();
        }

        private void My_Second_Form_Load(object sender, EventArgs e)
        {
            MessageBox.Show("What'up duck?");
        }

        private void My_Second_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Bye bye~");
        }
    }
}
