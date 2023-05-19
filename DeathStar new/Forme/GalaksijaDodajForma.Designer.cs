namespace DeathStar_new.Forme
{
    partial class GalaksijaDodajForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GalaksijaDodajForma));
            this.textNaziv = new System.Windows.Forms.TextBox();
            this.textBrojPlaneta = new System.Windows.Forms.TextBox();
            this.textBrojZvezda = new System.Windows.Forms.TextBox();
            this.textDominatnaRasa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Podaci = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Podaci.SuspendLayout();
            this.SuspendLayout();
            // 
            // textNaziv
            // 
            this.textNaziv.Location = new System.Drawing.Point(127, 28);
            this.textNaziv.Name = "textNaziv";
            this.textNaziv.Size = new System.Drawing.Size(121, 20);
            this.textNaziv.TabIndex = 0;
            this.textNaziv.TextChanged += new System.EventHandler(this.textNaziv_TextChanged);
            // 
            // textBrojPlaneta
            // 
            this.textBrojPlaneta.Location = new System.Drawing.Point(127, 56);
            this.textBrojPlaneta.Name = "textBrojPlaneta";
            this.textBrojPlaneta.Size = new System.Drawing.Size(121, 20);
            this.textBrojPlaneta.TabIndex = 1;
            // 
            // textBrojZvezda
            // 
            this.textBrojZvezda.Location = new System.Drawing.Point(127, 84);
            this.textBrojZvezda.Name = "textBrojZvezda";
            this.textBrojZvezda.Size = new System.Drawing.Size(121, 20);
            this.textBrojZvezda.TabIndex = 2;
            // 
            // textDominatnaRasa
            // 
            this.textDominatnaRasa.Location = new System.Drawing.Point(127, 112);
            this.textDominatnaRasa.Name = "textDominatnaRasa";
            this.textDominatnaRasa.Size = new System.Drawing.Size(121, 20);
            this.textDominatnaRasa.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Location = new System.Drawing.Point(20, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Broj planeta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Location = new System.Drawing.Point(20, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Broj zvezda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Location = new System.Drawing.Point(20, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dominatna rasa";
            // 
            // Podaci
            // 
            this.Podaci.Controls.Add(this.label4);
            this.Podaci.Controls.Add(this.label3);
            this.Podaci.Controls.Add(this.label2);
            this.Podaci.Controls.Add(this.label1);
            this.Podaci.Controls.Add(this.textDominatnaRasa);
            this.Podaci.Controls.Add(this.textBrojZvezda);
            this.Podaci.Controls.Add(this.textBrojPlaneta);
            this.Podaci.Controls.Add(this.textNaziv);
            this.Podaci.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Podaci.Location = new System.Drawing.Point(12, 24);
            this.Podaci.Name = "Podaci";
            this.Podaci.Size = new System.Drawing.Size(268, 147);
            this.Podaci.TabIndex = 9;
            this.Podaci.TabStop = false;
            this.Podaci.Text = "Podaci";
            this.Podaci.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(42, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GalaksijaDodajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(285, 251);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Podaci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GalaksijaDodajForma";
            this.Text = "GalaksijaDodajForma";
            this.Load += new System.EventHandler(this.GalaksijaDodajForma_Load);
            this.Podaci.ResumeLayout(false);
            this.Podaci.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textNaziv;
        private System.Windows.Forms.TextBox textBrojPlaneta;
        private System.Windows.Forms.TextBox textBrojZvezda;
        private System.Windows.Forms.TextBox textDominatnaRasa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Podaci;
        private System.Windows.Forms.Button button1;
    }
}