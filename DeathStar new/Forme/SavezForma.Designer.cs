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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavezForma));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listaSaveza = new System.Windows.Forms.ListView();
            this.Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum_formiranja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Prikazi_Clanove_Saveza = new System.Windows.Forms.Button();
            this.Pridruzi_Savez = new System.Windows.Forms.Button();
            this.Dodaj_Savez = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaSaveza);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Svi savezi";
            // 
            // listaSaveza
            // 
            this.listaSaveza.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naziv,
            this.Datum_formiranja});
            this.listaSaveza.FullRowSelect = true;
            this.listaSaveza.GridLines = true;
            this.listaSaveza.HideSelection = false;
            this.listaSaveza.Location = new System.Drawing.Point(7, 21);
            this.listaSaveza.Name = "listaSaveza";
            this.listaSaveza.Size = new System.Drawing.Size(560, 399);
            this.listaSaveza.TabIndex = 0;
            this.listaSaveza.UseCompatibleStateImageBehavior = false;
            this.listaSaveza.View = System.Windows.Forms.View.Details;
            this.listaSaveza.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Naziv
            // 
            this.Naziv.Text = "Naziv";
            this.Naziv.Width = 290;
            // 
            // Datum_formiranja
            // 
            this.Datum_formiranja.Text = "Datum formiranja";
            this.Datum_formiranja.Width = 267;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Prikazi_Clanove_Saveza);
            this.groupBox2.Controls.Add(this.Pridruzi_Savez);
            this.groupBox2.Controls.Add(this.Dodaj_Savez);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(603, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 425);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "O savezima";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Prikazi_Clanove_Saveza
            // 
            this.Prikazi_Clanove_Saveza.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Prikazi_Clanove_Saveza.Location = new System.Drawing.Point(7, 80);
            this.Prikazi_Clanove_Saveza.Name = "Prikazi_Clanove_Saveza";
            this.Prikazi_Clanove_Saveza.Size = new System.Drawing.Size(172, 23);
            this.Prikazi_Clanove_Saveza.TabIndex = 2;
            this.Prikazi_Clanove_Saveza.Text = "Prikazi članove saveza";
            this.Prikazi_Clanove_Saveza.UseVisualStyleBackColor = true;
            // 
            // Pridruzi_Savez
            // 
            this.Pridruzi_Savez.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pridruzi_Savez.Location = new System.Drawing.Point(7, 50);
            this.Pridruzi_Savez.Name = "Pridruzi_Savez";
            this.Pridruzi_Savez.Size = new System.Drawing.Size(172, 23);
            this.Pridruzi_Savez.TabIndex = 1;
            this.Pridruzi_Savez.Text = "Pridruzi savez";
            this.Pridruzi_Savez.UseVisualStyleBackColor = true;
            this.Pridruzi_Savez.Click += new System.EventHandler(this.Pridruzi_Savez_Click);
            // 
            // Dodaj_Savez
            // 
            this.Dodaj_Savez.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Dodaj_Savez.Location = new System.Drawing.Point(7, 20);
            this.Dodaj_Savez.Name = "Dodaj_Savez";
            this.Dodaj_Savez.Size = new System.Drawing.Size(172, 23);
            this.Dodaj_Savez.TabIndex = 0;
            this.Dodaj_Savez.Text = "Dodaj savez";
            this.Dodaj_Savez.UseVisualStyleBackColor = true;
            this.Dodaj_Savez.Click += new System.EventHandler(this.Dodaj_Savez_Click);
            // 
            // SavezForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ListView listaSaveza;
        private System.Windows.Forms.ColumnHeader Naziv;
        private System.Windows.Forms.ColumnHeader Datum_formiranja;
    }
}