namespace Example_UI_1._3a
{
    partial class DragonCatching3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DragonCatching3));
            this.pictureBoxDuragon = new System.Windows.Forms.PictureBox();
            this.pictureBoxFire = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDuragon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFire)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDuragon
            // 
            this.pictureBoxDuragon.Image = global::Example_UI_1._3a.Properties.Resources.shoyru_halloween_baby;
            this.pictureBoxDuragon.InitialImage = global::Example_UI_1._3a.Properties.Resources.shoyru_halloween_baby;
            this.pictureBoxDuragon.Location = new System.Drawing.Point(206, 183);
            this.pictureBoxDuragon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxDuragon.Name = "pictureBoxDuragon";
            this.pictureBoxDuragon.Size = new System.Drawing.Size(92, 88);
            this.pictureBoxDuragon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDuragon.TabIndex = 0;
            this.pictureBoxDuragon.TabStop = false;
            this.pictureBoxDuragon.Visible = false;
            this.pictureBoxDuragon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDuragon_MouseMove);
            // 
            // pictureBoxFire
            // 
            this.pictureBoxFire.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFire.Image")));
            this.pictureBoxFire.InitialImage = global::Example_UI_1._3a.Properties.Resources.shoyru_halloween_baby;
            this.pictureBoxFire.Location = new System.Drawing.Point(310, 255);
            this.pictureBoxFire.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxFire.Name = "pictureBoxFire";
            this.pictureBoxFire.Size = new System.Drawing.Size(80, 68);
            this.pictureBoxFire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFire.TabIndex = 1;
            this.pictureBoxFire.TabStop = false;
            this.pictureBoxFire.Click += new System.EventHandler(this.pictureBoxFire_Click);
            this.pictureBoxFire.DoubleClick += new System.EventHandler(this.pictureBoxFire_DoubleClick);
            // 
            // DragonCatching3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(556, 339);
            this.Controls.Add(this.pictureBoxFire);
            this.Controls.Add(this.pictureBoxDuragon);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DragonCatching3";
            this.Text = "DragonCatching3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDuragon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFire)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDuragon;
        private System.Windows.Forms.PictureBox pictureBoxFire;
    }
}