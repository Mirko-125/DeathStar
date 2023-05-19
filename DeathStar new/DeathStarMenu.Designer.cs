namespace DeathStar_new
{
    partial class DeathStarMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeathStarMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Igraci = new System.Windows.Forms.Button();
            this.Galaksije = new System.Windows.Forms.Button();
            this.Savezi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(84, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 168);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Igraci
            // 
            this.Igraci.Location = new System.Drawing.Point(114, 19);
            this.Igraci.Name = "Igraci";
            this.Igraci.Size = new System.Drawing.Size(75, 23);
            this.Igraci.TabIndex = 1;
            this.Igraci.Text = "Igrači";
            this.Igraci.UseVisualStyleBackColor = true;
            this.Igraci.Click += new System.EventHandler(this.Igraci_Click);
            // 
            // Galaksije
            // 
            this.Galaksije.Location = new System.Drawing.Point(114, 64);
            this.Galaksije.Name = "Galaksije";
            this.Galaksije.Size = new System.Drawing.Size(75, 23);
            this.Galaksije.TabIndex = 2;
            this.Galaksije.Text = "Galaksije";
            this.Galaksije.UseVisualStyleBackColor = true;
            this.Galaksije.Click += new System.EventHandler(this.Galaksije_Click);
            // 
            // Savezi
            // 
            this.Savezi.Location = new System.Drawing.Point(114, 107);
            this.Savezi.Name = "Savezi";
            this.Savezi.Size = new System.Drawing.Size(75, 23);
            this.Savezi.TabIndex = 3;
            this.Savezi.Text = "Savezi";
            this.Savezi.UseVisualStyleBackColor = true;
            this.Savezi.Click += new System.EventHandler(this.Savezi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Igraci);
            this.groupBox1.Controls.Add(this.Savezi);
            this.groupBox1.Controls.Add(this.Galaksije);
            this.groupBox1.Location = new System.Drawing.Point(84, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 208);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Glavni meni";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "testing";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeathStarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeathStarMenu";
            this.Text = "DeathStarMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Igraci;
        private System.Windows.Forms.Button Galaksije;
        private System.Windows.Forms.Button Savezi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}