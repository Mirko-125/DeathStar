namespace DeathStar_new.Forme
{
    partial class KvadrantiForma
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
            this.listaKvadranta = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.obrisiKvadrant = new System.Windows.Forms.Button();
            this.izmeniKvadrant = new System.Windows.Forms.Button();
            this.dodajKvadrant = new System.Windows.Forms.Button();
            this.textPrecnik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listaKvadranta
            // 
            this.listaKvadranta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listaKvadranta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader14});
            this.listaKvadranta.FullRowSelect = true;
            this.listaKvadranta.GridLines = true;
            this.listaKvadranta.HideSelection = false;
            this.listaKvadranta.Location = new System.Drawing.Point(18, 12);
            this.listaKvadranta.Name = "listaKvadranta";
            this.listaKvadranta.Size = new System.Drawing.Size(187, 129);
            this.listaKvadranta.TabIndex = 1;
            this.listaKvadranta.UseCompatibleStateImageBehavior = false;
            this.listaKvadranta.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Redni Broj";
            this.columnHeader10.Width = 63;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Procenjen Precnik";
            this.columnHeader14.Width = 111;
            // 
            // obrisiKvadrant
            // 
            this.obrisiKvadrant.BackColor = System.Drawing.Color.Maroon;
            this.obrisiKvadrant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.obrisiKvadrant.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obrisiKvadrant.ForeColor = System.Drawing.SystemColors.Control;
            this.obrisiKvadrant.Location = new System.Drawing.Point(17, 254);
            this.obrisiKvadrant.Name = "obrisiKvadrant";
            this.obrisiKvadrant.Size = new System.Drawing.Size(187, 36);
            this.obrisiKvadrant.TabIndex = 5;
            this.obrisiKvadrant.Text = "Obriši kvadrant";
            this.obrisiKvadrant.UseVisualStyleBackColor = false;
            this.obrisiKvadrant.Click += new System.EventHandler(this.obrisiKvadrant_Click);
            // 
            // izmeniKvadrant
            // 
            this.izmeniKvadrant.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.izmeniKvadrant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izmeniKvadrant.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izmeniKvadrant.ForeColor = System.Drawing.SystemColors.Control;
            this.izmeniKvadrant.Location = new System.Drawing.Point(17, 210);
            this.izmeniKvadrant.Name = "izmeniKvadrant";
            this.izmeniKvadrant.Size = new System.Drawing.Size(188, 38);
            this.izmeniKvadrant.TabIndex = 4;
            this.izmeniKvadrant.Text = "Izmeni kvadrant";
            this.izmeniKvadrant.UseVisualStyleBackColor = false;
            this.izmeniKvadrant.Click += new System.EventHandler(this.izmeniKvadrant_Click);
            // 
            // dodajKvadrant
            // 
            this.dodajKvadrant.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.dodajKvadrant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajKvadrant.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajKvadrant.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dodajKvadrant.Location = new System.Drawing.Point(18, 154);
            this.dodajKvadrant.Name = "dodajKvadrant";
            this.dodajKvadrant.Size = new System.Drawing.Size(104, 46);
            this.dodajKvadrant.TabIndex = 3;
            this.dodajKvadrant.Text = "Dodaj kvadrant";
            this.dodajKvadrant.UseVisualStyleBackColor = false;
            this.dodajKvadrant.Click += new System.EventHandler(this.dodajKvadrant_Click);
            // 
            // textPrecnik
            // 
            this.textPrecnik.Location = new System.Drawing.Point(136, 177);
            this.textPrecnik.Name = "textPrecnik";
            this.textPrecnik.Size = new System.Drawing.Size(68, 20);
            this.textPrecnik.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(149, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Precnik";
            // 
            // KvadrantiForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(226, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPrecnik);
            this.Controls.Add(this.obrisiKvadrant);
            this.Controls.Add(this.izmeniKvadrant);
            this.Controls.Add(this.dodajKvadrant);
            this.Controls.Add(this.listaKvadranta);
            this.Name = "KvadrantiForma";
            this.Text = "KvadrantiForma";
            this.Load += new System.EventHandler(this.KvadrantiForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listaKvadranta;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Button obrisiKvadrant;
        private System.Windows.Forms.Button izmeniKvadrant;
        private System.Windows.Forms.Button dodajKvadrant;
        private System.Windows.Forms.TextBox textPrecnik;
        private System.Windows.Forms.Label label1;
    }
}