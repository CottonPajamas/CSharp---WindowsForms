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
    public partial class DragonCatching3 : Form
    {
        Random rnd;
        int a = 138, b = 135;

        public DragonCatching3()
        {
            InitializeComponent();
            rnd = new Random();
        }
        
        private void pictureBoxFire_Click(object sender, EventArgs e)
        {
            this.pictureBoxDuragon.Visible = true;
        }

        private void pictureBoxDuragon_MouseMove(object sender, MouseEventArgs e)
        {
            this.pictureBoxDuragon.Visible = false;

            //Making it change its position when it goes invisible.
            int c = rnd.Next(1, 530);
            int d = rnd.Next(1, 320);
            this.pictureBoxDuragon.Location = new System.Drawing.Point(c, d);
        }

        private void pictureBoxFire_DoubleClick(object sender, EventArgs e)
        {
            this.pictureBoxDuragon.Visible = true;
            a += 50 ;
            b += 50;
            //This here changes its size
            this.pictureBoxDuragon.Size = new System.Drawing.Size(a, b);
        }
    }
}
