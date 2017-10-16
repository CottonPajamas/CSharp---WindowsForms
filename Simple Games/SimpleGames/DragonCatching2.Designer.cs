namespace Example_UI_1._3a
{
    partial class DragonCatching2
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
            this.btnFish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFish
            // 
            this.btnFish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFish.ForeColor = System.Drawing.Color.Yellow;
            this.btnFish.Image = global::Example_UI_1._3a.Properties.Resources.shoyru_halloween_baby;
            this.btnFish.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFish.Location = new System.Drawing.Point(147, 121);
            this.btnFish.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFish.Name = "btnFish";
            this.btnFish.Size = new System.Drawing.Size(101, 88);
            this.btnFish.TabIndex = 2;
            this.btnFish.Text = "Fish";
            this.btnFish.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFish.UseVisualStyleBackColor = true;
            this.btnFish.MouseEnter += new System.EventHandler(this.btnFish_MouseEnter);
            // 
            // DragonCatching2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 330);
            this.Controls.Add(this.btnFish);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DragonCatching2";
            this.Text = "DragonCatching2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFish;
    }
}