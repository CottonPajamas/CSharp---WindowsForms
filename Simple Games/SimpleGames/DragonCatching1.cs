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
    public partial class DragonCatching1 : Form
    {
        Random rnd;

        public DragonCatching1()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void CatchARabbit_Load(object sender, EventArgs e)
        {

        }

        private void btnRabbit_Click(object sender, EventArgs e)
        {
            int a = rnd.Next(1, 300);
            int b = rnd.Next(1, 300);
            this.btnRabbit.Location = new System.Drawing.Point(a, b);
        }
    }
}
