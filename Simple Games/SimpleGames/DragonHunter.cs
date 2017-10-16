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
    public partial class DragonHunter : Form
    {
        Random rnd;

        public DragonHunter()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void btnRabbit_MouseDown(object sender, MouseEventArgs e)
        {
            this.btnRabbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRabbit.Text = "Sorry";
        }

        private void btnRabbit_MouseUp(object sender, MouseEventArgs e)
        {
            int a = rnd.Next(1, 300);
            int b = rnd.Next(1, 300);
            this.btnRabbit.Location = new System.Drawing.Point(a, b);
            this.btnRabbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRabbit.Text = "Imma kill!!!";
        }
    }
}
