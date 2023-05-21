namespace DeathStar_new.Forme
{
    partial class KonstrukcijaStaniceForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KonstrukcijaStaniceForma));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SvrhaComboBox = new System.Windows.Forms.ComboBox();
            this.civilnaRadio = new System.Windows.Forms.RadioButton();
            this.vojnaRadio = new System.Windows.Forms.RadioButton();
            this.Konstruisi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.velicinaTextBox = new System.Windows.Forms.TextBox();
            this.Velicina = new System.Windows.Forms.Label();
            this.BrojLjudiText = new System.Windows.Forms.TextBox();
            this.UdaljenostText = new System.Windows.Forms.TextBox();
            this.NazivText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.SvrhaComboBox);
            this.groupBox4.Controls.Add(this.civilnaRadio);
            this.groupBox4.Controls.Add(this.vojnaRadio);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(263, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(203, 188);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Specijalizacija";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Svrha";
            // 
            // SvrhaComboBox
            // 
            this.SvrhaComboBox.FormattingEnabled = true;
            this.SvrhaComboBox.Items.AddRange(new object[] {
            "trgovina",
            "nauka"});
            this.SvrhaComboBox.Location = new System.Drawing.Point(53, 86);
            this.SvrhaComboBox.Name = "SvrhaComboBox";
            this.SvrhaComboBox.Size = new System.Drawing.Size(113, 21);
            this.SvrhaComboBox.TabIndex = 3;
            // 
            // civilnaRadio
            // 
            this.civilnaRadio.AutoSize = true;
            this.civilnaRadio.Location = new System.Drawing.Point(53, 59);
            this.civilnaRadio.Name = "civilnaRadio";
            this.civilnaRadio.Size = new System.Drawing.Size(56, 17);
            this.civilnaRadio.TabIndex = 17;
            this.civilnaRadio.TabStop = true;
            this.civilnaRadio.Text = "Civilna";
            this.civilnaRadio.UseVisualStyleBackColor = true;
            // 
            // vojnaRadio
            // 
            this.vojnaRadio.AutoSize = true;
            this.vojnaRadio.Location = new System.Drawing.Point(53, 31);
            this.vojnaRadio.Name = "vojnaRadio";
            this.vojnaRadio.Size = new System.Drawing.Size(52, 17);
            this.vojnaRadio.TabIndex = 16;
            this.vojnaRadio.TabStop = true;
            this.vojnaRadio.Text = "Vojna";
            this.vojnaRadio.UseVisualStyleBackColor = true;
            // 
            // Konstruisi
            // 
            this.Konstruisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Konstruisi.Font = new System.Drawing.Font("Consolas", 14F);
            this.Konstruisi.Location = new System.Drawing.Point(326, 222);
            this.Konstruisi.Name = "Konstruisi";
            this.Konstruisi.Size = new System.Drawing.Size(140, 54);
            this.Konstruisi.TabIndex = 22;
            this.Konstruisi.Text = "Konstruiši";
            this.Konstruisi.UseVisualStyleBackColor = false;
            this.Konstruisi.Click += new System.EventHandler(this.Konstruisi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.velicinaTextBox);
            this.groupBox1.Controls.Add(this.Velicina);
            this.groupBox1.Controls.Add(this.BrojLjudiText);
            this.groupBox1.Controls.Add(this.UdaljenostText);
            this.groupBox1.Controls.Add(this.NazivText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 221);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnove broda";
            // 
            // velicinaTextBox
            // 
            this.velicinaTextBox.Location = new System.Drawing.Point(98, 140);
            this.velicinaTextBox.Name = "velicinaTextBox";
            this.velicinaTextBox.Size = new System.Drawing.Size(98, 20);
            this.velicinaTextBox.TabIndex = 12;
            // 
            // Velicina
            // 
            this.Velicina.AutoSize = true;
            this.Velicina.Location = new System.Drawing.Point(11, 142);
            this.Velicina.Name = "Velicina";
            this.Velicina.Size = new System.Drawing.Size(44, 13);
            this.Velicina.TabIndex = 11;
            this.Velicina.Text = "Veličina";
            // 
            // BrojLjudiText
            // 
            this.BrojLjudiText.Location = new System.Drawing.Point(97, 111);
            this.BrojLjudiText.Name = "BrojLjudiText";
            this.BrojLjudiText.Size = new System.Drawing.Size(100, 20);
            this.BrojLjudiText.TabIndex = 9;
            // 
            // UdaljenostText
            // 
            this.UdaljenostText.Location = new System.Drawing.Point(97, 85);
            this.UdaljenostText.Name = "UdaljenostText";
            this.UdaljenostText.Size = new System.Drawing.Size(100, 20);
            this.UdaljenostText.TabIndex = 7;
            // 
            // NazivText
            // 
            this.NazivText.Location = new System.Drawing.Point(97, 60);
            this.NazivText.Name = "NazivText";
            this.NazivText.Size = new System.Drawing.Size(100, 20);
            this.NazivText.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Udaljenost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Broj Ljudi";
            // 
            // KonstrukcijaStaniceForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(488, 288);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Konstruisi);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KonstrukcijaStaniceForma";
            this.Text = "KonstrukcijaStaniceForma";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton civilnaRadio;
        private System.Windows.Forms.RadioButton vojnaRadio;
        private System.Windows.Forms.Button Konstruisi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox BrojLjudiText;
        private System.Windows.Forms.TextBox UdaljenostText;
        private System.Windows.Forms.TextBox NazivText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Velicina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SvrhaComboBox;
        private System.Windows.Forms.TextBox velicinaTextBox;
    }
}