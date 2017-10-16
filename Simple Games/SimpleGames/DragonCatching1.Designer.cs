namespace Example_UI_1._3a
{
    partial class DragonCatching1
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
            this.btnRabbit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRabbit
            // 
            this.btnRabbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRabbit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRabbit.Image = global::Example_UI_1._3a.Properties.Resources.shoyru_halloween_baby;
            this.btnRabbit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRabbit.Location = new System.Drawing.Point(139, 218);
            this.btnRabbit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRabbit.Name = "btnRabbit";
            this.btnRabbit.Size = new System.Drawing.Size(101, 88);
            this.btnRabbit.TabIndex = 0;
            this.btnRabbit.Text = "Rabbit";
            this.btnRabbit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRabbit.UseVisualStyleBackColor = true;
            this.btnRabbit.Click += new System.EventHandler(this.btnRabbit_Click);
            // 
            // DragonCatching1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 410);
            this.Controls.Add(this.btnRabbit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DragonCatching1";
            this.Text = "DragonCatching1";
            this.Load += new System.EventHandler(this.CatchARabbit_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRabbit;
    }
}