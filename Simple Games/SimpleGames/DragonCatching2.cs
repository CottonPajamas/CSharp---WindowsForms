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
    public partial class DragonCatching2 : Form
    {
        Random rnd;

        public DragonCatching2()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void btnFish_MouseEnter(object sender, EventArgs e)
        {
            int a = rnd.Next(1, 300);
            int b = rnd.Next(1, 300);
            this.btnFish.Location = new System.Drawing.Point(a, b);
            this.btnFish.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFish.Text = "Imma kill!!!";
        }
    }
}
