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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Dodaj_Igraca = new System.Windows.Forms.Button();
            this.Obrisi_Igraca = new System.Windows.Forms.Button();
            this.Izmeni_Igraca = new System.Windows.Forms.Button();
            this.Izaberi_Posadu = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista igrača";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Izmeni_Igraca);
            this.groupBox2.Controls.Add(this.Obrisi_Igraca);
            this.groupBox2.Controls.Add(this.Dodaj_Igraca);
            this.groupBox2.Location = new System.Drawing.Point(556, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 259);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meni za igrače";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Izaberi_Posadu);
            this.groupBox3.Location = new System.Drawing.Point(556, 278);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 68);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Posade";
            // 
            // Dodaj_Igraca
            // 
            this.Dodaj_Igraca.Location = new System.Drawing.Point(7, 20);
            this.Dodaj_Igraca.Name = "Dodaj_Igraca";
            this.Dodaj_Igraca.Size = new System.Drawing.Size(187, 23);
            this.Dodaj_Igraca.TabIndex = 0;
            this.Dodaj_Igraca.Text = "Dodaj igrača";
            this.Dodaj_Igraca.UseVisualStyleBackColor = true;
            // 
            // Obrisi_Igraca
            // 
            this.Obrisi_Igraca.Location = new System.Drawing.Point(7, 49);
            this.Obrisi_Igraca.Name = "Obrisi_Igraca";
            this.Obrisi_Igraca.Size = new System.Drawing.Size(187, 23);
            this.Obrisi_Igraca.TabIndex = 1;
            this.Obrisi_Igraca.Text = "Obriši igrača";
            this.Obrisi_Igraca.UseVisualStyleBackColor = true;
            // 
            // Izmeni_Igraca
            // 
            this.Izmeni_Igraca.Location = new System.Drawing.Point(7, 78);
            this.Izmeni_Igraca.Name = "Izmeni_Igraca";
            this.Izmeni_Igraca.Size = new System.Drawing.Size(187, 23);
            this.Izmeni_Igraca.TabIndex = 2;
            this.Izmeni_Igraca.Text = "Izmeni igrača";
            this.Izmeni_Igraca.UseVisualStyleBackColor = true;
            // 
            // Izaberi_Posadu
            // 
            this.Izaberi_Posadu.Location = new System.Drawing.Point(7, 20);
            this.Izaberi_Posadu.Name = "Izaberi_Posadu";
            this.Izaberi_Posadu.Size = new System.Drawing.Size(187, 23);
            this.Izaberi_Posadu.TabIndex = 0;
            this.Izaberi_Posadu.Text = "Izaberi posadu";
            this.Izaberi_Posadu.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(510, 400);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // IgracForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "IgracForma";
            this.Text = "Igrac";
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
        private System.Windows.Forms.ListView listView1;
    }
}