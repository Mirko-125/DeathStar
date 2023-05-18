namespace DeathStar_new.Forme
{
    partial class SavezForma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Dodaj_Savez = new System.Windows.Forms.Button();
            this.Pridruzi_Savez = new System.Windows.Forms.Button();
            this.Prikazi_Clanove_Saveza = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Svi savezi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Prikazi_Clanove_Saveza);
            this.groupBox2.Controls.Add(this.Pridruzi_Savez);
            this.groupBox2.Controls.Add(this.Dodaj_Savez);
            this.groupBox2.Location = new System.Drawing.Point(603, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 425);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "O savezima";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Dodaj_Savez
            // 
            this.Dodaj_Savez.Location = new System.Drawing.Point(7, 20);
            this.Dodaj_Savez.Name = "Dodaj_Savez";
            this.Dodaj_Savez.Size = new System.Drawing.Size(172, 23);
            this.Dodaj_Savez.TabIndex = 0;
            this.Dodaj_Savez.Text = "Dodaj savez";
            this.Dodaj_Savez.UseVisualStyleBackColor = true;
            // 
            // Pridruzi_Savez
            // 
            this.Pridruzi_Savez.Location = new System.Drawing.Point(7, 50);
            this.Pridruzi_Savez.Name = "Pridruzi_Savez";
            this.Pridruzi_Savez.Size = new System.Drawing.Size(172, 23);
            this.Pridruzi_Savez.TabIndex = 1;
            this.Pridruzi_Savez.Text = "Pridruzi savez";
            this.Pridruzi_Savez.UseVisualStyleBackColor = true;
            // 
            // Prikazi_Clanove_Saveza
            // 
            this.Prikazi_Clanove_Saveza.Location = new System.Drawing.Point(7, 80);
            this.Prikazi_Clanove_Saveza.Name = "Prikazi_Clanove_Saveza";
            this.Prikazi_Clanove_Saveza.Size = new System.Drawing.Size(172, 23);
            this.Prikazi_Clanove_Saveza.TabIndex = 2;
            this.Prikazi_Clanove_Saveza.Text = "Prikazi članove saveza";
            this.Prikazi_Clanove_Saveza.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(560, 399);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // SavezForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SavezForma";
            this.Text = "Savez";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Prikazi_Clanove_Saveza;
        private System.Windows.Forms.Button Pridruzi_Savez;
        private System.Windows.Forms.Button Dodaj_Savez;
        private System.Windows.Forms.ListView listView1;
    }
}