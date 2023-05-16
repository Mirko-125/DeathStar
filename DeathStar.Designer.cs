namespace DeathStar.Entiteti
{
    partial class DeathStar
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Igraci = new System.Windows.Forms.Button();
            this.Galaksije = new System.Windows.Forms.Button();
            this.Savezi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(65, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(567, 162);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Igraci
            // 
            this.Igraci.Location = new System.Drawing.Point(184, 282);
            this.Igraci.Name = "Igraci";
            this.Igraci.Size = new System.Drawing.Size(316, 23);
            this.Igraci.TabIndex = 1;
            this.Igraci.Text = "Igrači";
            this.Igraci.UseVisualStyleBackColor = true;
            this.Igraci.Click += new System.EventHandler(this.button1_Click);
            // 
            // Galaksije
            // 
            this.Galaksije.Location = new System.Drawing.Point(184, 329);
            this.Galaksije.Name = "Galaksije";
            this.Galaksije.Size = new System.Drawing.Size(316, 23);
            this.Galaksije.TabIndex = 2;
            this.Galaksije.Text = "Glaksije";
            this.Galaksije.UseVisualStyleBackColor = true;
            this.Galaksije.Click += new System.EventHandler(this.Galaksije_Click);
            // 
            // Savezi
            // 
            this.Savezi.Location = new System.Drawing.Point(184, 377);
            this.Savezi.Name = "Savezi";
            this.Savezi.Size = new System.Drawing.Size(316, 23);
            this.Savezi.TabIndex = 3;
            this.Savezi.Text = "Savezi";
            this.Savezi.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 233);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "DEATHSTAR";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DeathStar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(688, 568);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Savezi);
            this.Controls.Add(this.Galaksije);
            this.Controls.Add(this.Igraci);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DeathStar";
            this.Text = "DeathStar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button Igraci;
        private Button Galaksije;
        private Button Savezi;
        private TextBox textBox1;
    }
}