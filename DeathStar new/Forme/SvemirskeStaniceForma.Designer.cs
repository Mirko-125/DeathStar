namespace DeathStar_new.Forme
{
    partial class SvemirskeStaniceForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SvemirskeStaniceForma));
            this.dodajStanicu = new System.Windows.Forms.Button();
            this.groupbox16 = new System.Windows.Forms.GroupBox();
            this.listaCivilnihStanica = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listaVojnihStanica = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrikazOruzja = new System.Windows.Forms.Button();
            this.groupbox16.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dodajStanicu
            // 
            this.dodajStanicu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dodajStanicu.Font = new System.Drawing.Font("Consolas", 14F);
            this.dodajStanicu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dodajStanicu.Location = new System.Drawing.Point(12, 493);
            this.dodajStanicu.Name = "dodajStanicu";
            this.dodajStanicu.Size = new System.Drawing.Size(207, 68);
            this.dodajStanicu.TabIndex = 6;
            this.dodajStanicu.Text = "Dodaj stanicu!";
            this.dodajStanicu.UseVisualStyleBackColor = false;
            this.dodajStanicu.Click += new System.EventHandler(this.dodajStanicu_Click);
            // 
            // groupbox16
            // 
            this.groupbox16.Controls.Add(this.listaCivilnihStanica);
            this.groupbox16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupbox16.Location = new System.Drawing.Point(12, 275);
            this.groupbox16.Name = "groupbox16";
            this.groupbox16.Size = new System.Drawing.Size(438, 202);
            this.groupbox16.TabIndex = 5;
            this.groupbox16.TabStop = false;
            this.groupbox16.Text = "Civilne Stanice";
            // 
            // listaCivilnihStanica
            // 
            this.listaCivilnihStanica.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader6});
            this.listaCivilnihStanica.FullRowSelect = true;
            this.listaCivilnihStanica.GridLines = true;
            this.listaCivilnihStanica.HideSelection = false;
            this.listaCivilnihStanica.Location = new System.Drawing.Point(9, 19);
            this.listaCivilnihStanica.Name = "listaCivilnihStanica";
            this.listaCivilnihStanica.Size = new System.Drawing.Size(415, 171);
            this.listaCivilnihStanica.TabIndex = 0;
            this.listaCivilnihStanica.UseCompatibleStateImageBehavior = false;
            this.listaCivilnihStanica.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Id";
            this.columnHeader7.Width = 27;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Naziv";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Udaljenost";
            this.columnHeader9.Width = 95;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Broj Ljudi";
            this.columnHeader10.Width = 56;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Velicina";
            this.columnHeader11.Width = 58;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Svrha";
            this.columnHeader6.Width = 92;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaVojnihStanica);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 257);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vojne Stanice";
            // 
            // listaVojnihStanica
            // 
            this.listaVojnihStanica.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listaVojnihStanica.FullRowSelect = true;
            this.listaVojnihStanica.GridLines = true;
            this.listaVojnihStanica.HideSelection = false;
            this.listaVojnihStanica.Location = new System.Drawing.Point(9, 19);
            this.listaVojnihStanica.Name = "listaVojnihStanica";
            this.listaVojnihStanica.Size = new System.Drawing.Size(415, 226);
            this.listaVojnihStanica.TabIndex = 0;
            this.listaVojnihStanica.UseCompatibleStateImageBehavior = false;
            this.listaVojnihStanica.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 31;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Udaljenost";
            this.columnHeader3.Width = 101;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Broj Ljudi";
            this.columnHeader4.Width = 112;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Velicina";
            this.columnHeader5.Width = 88;
            // 
            // PrikazOruzja
            // 
            this.PrikazOruzja.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PrikazOruzja.Font = new System.Drawing.Font("Consolas", 14F);
            this.PrikazOruzja.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PrikazOruzja.Location = new System.Drawing.Point(250, 493);
            this.PrikazOruzja.Name = "PrikazOruzja";
            this.PrikazOruzja.Size = new System.Drawing.Size(200, 66);
            this.PrikazOruzja.TabIndex = 7;
            this.PrikazOruzja.Text = "Prikaži Oružje";
            this.PrikazOruzja.UseVisualStyleBackColor = false;
            this.PrikazOruzja.Click += new System.EventHandler(this.PrikazOruzja_Click);
            // 
            // SvemirskeStaniceForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(466, 572);
            this.Controls.Add(this.PrikazOruzja);
            this.Controls.Add(this.dodajStanicu);
            this.Controls.Add(this.groupbox16);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SvemirskeStaniceForma";
            this.Text = "SvemirskeStaniceForma";
            this.Load += new System.EventHandler(this.SvemirskeStaniceForma_Load);
            this.groupbox16.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dodajStanicu;
        private System.Windows.Forms.GroupBox groupbox16;
        private System.Windows.Forms.ListView listaCivilnihStanica;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listaVojnihStanica;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button PrikazOruzja;
    }
}