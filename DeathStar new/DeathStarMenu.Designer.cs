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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(64, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 197);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Igraci
            // 
            this.Igraci.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Igraci.Font = new System.Drawing.Font("Consolas", 14F);
            this.Igraci.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Igraci.Location = new System.Drawing.Point(99, 19);
            this.Igraci.Name = "Igraci";
            this.Igraci.Size = new System.Drawing.Size(154, 49);
            this.Igraci.TabIndex = 1;
            this.Igraci.Text = "Igrači";
            this.Igraci.UseVisualStyleBackColor = false;
            this.Igraci.Click += new System.EventHandler(this.Igraci_Click);
            // 
            // Galaksije
            // 
            this.Galaksije.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Galaksije.Font = new System.Drawing.Font("Consolas", 14F);
            this.Galaksije.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Galaksije.Location = new System.Drawing.Point(99, 83);
            this.Galaksije.Name = "Galaksije";
            this.Galaksije.Size = new System.Drawing.Size(154, 51);
            this.Galaksije.TabIndex = 2;
            this.Galaksije.Text = "Galaksije";
            this.Galaksije.UseVisualStyleBackColor = false;
            this.Galaksije.Click += new System.EventHandler(this.Galaksije_Click);
            // 
            // Savezi
            // 
            this.Savezi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Savezi.Font = new System.Drawing.Font("Consolas", 14F);
            this.Savezi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Savezi.Location = new System.Drawing.Point(99, 149);
            this.Savezi.Name = "Savezi";
            this.Savezi.Size = new System.Drawing.Size(154, 53);
            this.Savezi.TabIndex = 3;
            this.Savezi.Text = "Savezi";
            this.Savezi.UseVisualStyleBackColor = false;
            this.Savezi.Click += new System.EventHandler(this.Savezi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Igraci);
            this.groupBox1.Controls.Add(this.Savezi);
            this.groupBox1.Controls.Add(this.Galaksije);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(64, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 208);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Glavni meni";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "DEATHSTAR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DeathStarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(471, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeathStarMenu";
            this.Text = "DeathStarMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Igraci;
        private System.Windows.Forms.Button Galaksije;
        private System.Windows.Forms.Button Savezi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}