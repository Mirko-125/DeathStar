namespace DeathStar_new.Forme
{
    partial class IgracForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IgracForma));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listaIgraca = new System.Windows.Forms.ListView();
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Država = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum_rođenja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum_pridruživanja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.URL_Avatara = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Opis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Izmeni_Igraca = new System.Windows.Forms.Button();
            this.Obrisi_Igraca = new System.Windows.Forms.Button();
            this.Dodaj_Igraca = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Izaberi_Posadu = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaIgraca);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(931, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista igrača";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listaIgraca
            // 
            this.listaIgraca.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Username,
            this.Ime,
            this.Prezime,
            this.Pol,
            this.Država,
            this.Datum_rođenja,
            this.Datum_pridruživanja,
            this.Email,
            this.URL_Avatara,
            this.Opis});
            this.listaIgraca.FullRowSelect = true;
            this.listaIgraca.GridLines = true;
            this.listaIgraca.HideSelection = false;
            this.listaIgraca.Location = new System.Drawing.Point(7, 19);
            this.listaIgraca.Name = "listaIgraca";
            this.listaIgraca.Size = new System.Drawing.Size(918, 400);
            this.listaIgraca.TabIndex = 0;
            this.listaIgraca.UseCompatibleStateImageBehavior = false;
            this.listaIgraca.View = System.Windows.Forms.View.Details;
            this.listaIgraca.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Username
            // 
            this.Username.Text = "Username";
            this.Username.Width = 80;
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.Width = 84;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.Width = 86;
            // 
            // Pol
            // 
            this.Pol.Text = "Pol";
            this.Pol.Width = 59;
            // 
            // Država
            // 
            this.Država.Text = "Država";
            this.Država.Width = 85;
            // 
            // Datum_rođenja
            // 
            this.Datum_rođenja.Text = "Datum rođenja";
            this.Datum_rođenja.Width = 96;
            // 
            // Datum_pridruživanja
            // 
            this.Datum_pridruživanja.Text = "Datum pridruživanja";
            this.Datum_pridruživanja.Width = 109;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 88;
            // 
            // URL_Avatara
            // 
            this.URL_Avatara.Text = "URL Avatara";
            this.URL_Avatara.Width = 77;
            // 
            // Opis
            // 
            this.Opis.Text = "Opis";
            this.Opis.Width = 281;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Izmeni_Igraca);
            this.groupBox2.Controls.Add(this.Obrisi_Igraca);
            this.groupBox2.Controls.Add(this.Dodaj_Igraca);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(949, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 259);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meni za igrače";
            // 
            // Izmeni_Igraca
            // 
            this.Izmeni_Igraca.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Izmeni_Igraca.Location = new System.Drawing.Point(7, 78);
            this.Izmeni_Igraca.Name = "Izmeni_Igraca";
            this.Izmeni_Igraca.Size = new System.Drawing.Size(187, 23);
            this.Izmeni_Igraca.TabIndex = 2;
            this.Izmeni_Igraca.Text = "Izmeni igrača";
            this.Izmeni_Igraca.UseVisualStyleBackColor = true;
            this.Izmeni_Igraca.Click += new System.EventHandler(this.Izmeni_Igraca_Click);
            // 
            // Obrisi_Igraca
            // 
            this.Obrisi_Igraca.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Obrisi_Igraca.Location = new System.Drawing.Point(7, 49);
            this.Obrisi_Igraca.Name = "Obrisi_Igraca";
            this.Obrisi_Igraca.Size = new System.Drawing.Size(187, 23);
            this.Obrisi_Igraca.TabIndex = 1;
            this.Obrisi_Igraca.Text = "Obriši igrača";
            this.Obrisi_Igraca.UseVisualStyleBackColor = true;
            this.Obrisi_Igraca.Click += new System.EventHandler(this.Obrisi_Igraca_Click);
            // 
            // Dodaj_Igraca
            // 
            this.Dodaj_Igraca.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Dodaj_Igraca.Location = new System.Drawing.Point(7, 20);
            this.Dodaj_Igraca.Name = "Dodaj_Igraca";
            this.Dodaj_Igraca.Size = new System.Drawing.Size(187, 23);
            this.Dodaj_Igraca.TabIndex = 0;
            this.Dodaj_Igraca.Text = "Dodaj igrača";
            this.Dodaj_Igraca.UseVisualStyleBackColor = true;
            this.Dodaj_Igraca.Click += new System.EventHandler(this.Dodaj_Igraca_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Izaberi_Posadu);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(949, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 68);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Posade";
            // 
            // Izaberi_Posadu
            // 
            this.Izaberi_Posadu.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Izaberi_Posadu.Location = new System.Drawing.Point(6, 19);
            this.Izaberi_Posadu.Name = "Izaberi_Posadu";
            this.Izaberi_Posadu.Size = new System.Drawing.Size(187, 23);
            this.Izaberi_Posadu.TabIndex = 0;
            this.Izaberi_Posadu.Text = "Izaberi posadu";
            this.Izaberi_Posadu.UseVisualStyleBackColor = true;
            // 
            // IgracForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1161, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IgracForma";
            this.Text = "Igrac";
            this.Load += new System.EventHandler(this.IgracForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Izmeni_Igraca;
        private System.Windows.Forms.Button Obrisi_Igraca;
        private System.Windows.Forms.Button Dodaj_Igraca;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Izaberi_Posadu;
        private System.Windows.Forms.ListView listaIgraca;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader Pol;
        private System.Windows.Forms.ColumnHeader Država;
        private System.Windows.Forms.ColumnHeader Datum_rođenja;
        private System.Windows.Forms.ColumnHeader Datum_pridruživanja;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader URL_Avatara;
        private System.Windows.Forms.ColumnHeader Opis;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}