namespace DeathStar_new.Forme
{
    partial class BrodoviForma
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
            this.listaBorbenihBrodova = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupbox16 = new System.Windows.Forms.GroupBox();
            this.listaTransportnihBrodova = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.konstruisiBrod = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupbox16.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaBorbenihBrodova
            // 
            this.listaBorbenihBrodova.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listaBorbenihBrodova.FullRowSelect = true;
            this.listaBorbenihBrodova.GridLines = true;
            this.listaBorbenihBrodova.HideSelection = false;
            this.listaBorbenihBrodova.Location = new System.Drawing.Point(6, 19);
            this.listaBorbenihBrodova.Name = "listaBorbenihBrodova";
            this.listaBorbenihBrodova.Size = new System.Drawing.Size(502, 226);
            this.listaBorbenihBrodova.TabIndex = 0;
            this.listaBorbenihBrodova.UseCompatibleStateImageBehavior = false;
            this.listaBorbenihBrodova.View = System.Windows.Forms.View.Details;
            this.listaBorbenihBrodova.SelectedIndexChanged += new System.EventHandler(this.listaBorbenihBrodova_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Maksimalna brzina";
            this.columnHeader3.Width = 101;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "broj laserskih topova";
            this.columnHeader4.Width = 112;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tip broda";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fotonsko Torpedo";
            this.columnHeader6.Width = 101;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaBorbenihBrodova);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 257);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Borbeni Brodovi";
            // 
            // groupbox16
            // 
            this.groupbox16.Controls.Add(this.listaTransportnihBrodova);
            this.groupbox16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupbox16.Location = new System.Drawing.Point(12, 275);
            this.groupbox16.Name = "groupbox16";
            this.groupbox16.Size = new System.Drawing.Size(402, 202);
            this.groupbox16.TabIndex = 2;
            this.groupbox16.TabStop = false;
            this.groupbox16.Text = "Transportni Brodovi";
            // 
            // listaTransportnihBrodova
            // 
            this.listaTransportnihBrodova.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listaTransportnihBrodova.FullRowSelect = true;
            this.listaTransportnihBrodova.GridLines = true;
            this.listaTransportnihBrodova.HideSelection = false;
            this.listaTransportnihBrodova.Location = new System.Drawing.Point(9, 19);
            this.listaTransportnihBrodova.Name = "listaTransportnihBrodova";
            this.listaTransportnihBrodova.Size = new System.Drawing.Size(376, 171);
            this.listaTransportnihBrodova.TabIndex = 0;
            this.listaTransportnihBrodova.UseCompatibleStateImageBehavior = false;
            this.listaTransportnihBrodova.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Id";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Naziv";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Maksimalna brzina";
            this.columnHeader9.Width = 101;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Nosivost";
            this.columnHeader10.Width = 56;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Zastitna Otplata";
            this.columnHeader11.Width = 96;
            // 
            // konstruisiBrod
            // 
            this.konstruisiBrod.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.konstruisiBrod.Font = new System.Drawing.Font("Consolas", 14F);
            this.konstruisiBrod.Location = new System.Drawing.Point(440, 397);
            this.konstruisiBrod.Name = "konstruisiBrod";
            this.konstruisiBrod.Size = new System.Drawing.Size(231, 68);
            this.konstruisiBrod.TabIndex = 3;
            this.konstruisiBrod.Text = "Konstruiši brod!";
            this.konstruisiBrod.UseVisualStyleBackColor = false;
            this.konstruisiBrod.Click += new System.EventHandler(this.konstruisiBrod_Click);
            // 
            // BrodoviForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(693, 489);
            this.Controls.Add(this.konstruisiBrod);
            this.Controls.Add(this.groupbox16);
            this.Controls.Add(this.groupBox1);
            this.Name = "BrodoviForma";
            this.Text = "BrodoviForma";
            this.Load += new System.EventHandler(this.BrodoviForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupbox16.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaBorbenihBrodova;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupbox16;
        private System.Windows.Forms.ListView listaTransportnihBrodova;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button konstruisiBrod;
    }
}