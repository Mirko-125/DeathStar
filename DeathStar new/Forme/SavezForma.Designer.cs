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
            this.Dodaj_Savez = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaSaveza);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 436);
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
            // Dodaj_Savez
            // 
            this.Dodaj_Savez.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dodaj_Savez.Font = new System.Drawing.Font("Consolas", 12F);
            this.Dodaj_Savez.ForeColor = System.Drawing.SystemColors.Control;
            this.Dodaj_Savez.Location = new System.Drawing.Point(223, 454);
            this.Dodaj_Savez.Name = "Dodaj_Savez";
            this.Dodaj_Savez.Size = new System.Drawing.Size(172, 43);
            this.Dodaj_Savez.TabIndex = 0;
            this.Dodaj_Savez.Text = "Dodaj savez";
            this.Dodaj_Savez.UseVisualStyleBackColor = false;
            this.Dodaj_Savez.Click += new System.EventHandler(this.Dodaj_Savez_Click);
            // 
            // SavezForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(623, 509);
            this.Controls.Add(this.Dodaj_Savez);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SavezForma";
            this.Text = "Savez";
            this.Load += new System.EventHandler(this.SavezForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Dodaj_Savez;
        private System.Windows.Forms.ListView listaSaveza;
        private System.Windows.Forms.ColumnHeader Naziv;
        private System.Windows.Forms.ColumnHeader Datum_formiranja;
    }
}