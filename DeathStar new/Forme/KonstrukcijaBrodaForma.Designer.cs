namespace DeathStar_new.Forme
{
    partial class KonstrukcijaBrodaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KonstrukcijaBrodaForma));
            this.Konstruisi = new System.Windows.Forms.Button();
            this.transportniRadio = new System.Windows.Forms.RadioButton();
            this.BorbeniBrodGroup = new System.Windows.Forms.GroupBox();
            this.BrojLaserskihTopovaText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TipComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FotonskoTorpedoCheckBox = new System.Windows.Forms.CheckBox();
            this.TransportniBrodGroup = new System.Windows.Forms.GroupBox();
            this.NosivostText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ZASTITNAOTPLATA = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PosadaIdText = new System.Windows.Forms.TextBox();
            this.MaxWarpBrzinaText = new System.Windows.Forms.TextBox();
            this.NazivText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.borbeniRadio = new System.Windows.Forms.RadioButton();
            this.BorbeniBrodGroup.SuspendLayout();
            this.TransportniBrodGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Konstruisi
            // 
            this.Konstruisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Konstruisi.Font = new System.Drawing.Font("Consolas", 14F);
            this.Konstruisi.Location = new System.Drawing.Point(731, 196);
            this.Konstruisi.Name = "Konstruisi";
            this.Konstruisi.Size = new System.Drawing.Size(140, 54);
            this.Konstruisi.TabIndex = 19;
            this.Konstruisi.Text = "Konstruiši";
            this.Konstruisi.UseVisualStyleBackColor = false;
            this.Konstruisi.Click += new System.EventHandler(this.Konstruisi_Click);
            // 
            // transportniRadio
            // 
            this.transportniRadio.AutoSize = true;
            this.transportniRadio.Location = new System.Drawing.Point(293, 53);
            this.transportniRadio.Name = "transportniRadio";
            this.transportniRadio.Size = new System.Drawing.Size(78, 17);
            this.transportniRadio.TabIndex = 17;
            this.transportniRadio.TabStop = true;
            this.transportniRadio.Text = "Transportni";
            this.transportniRadio.UseVisualStyleBackColor = true;
            this.transportniRadio.CheckedChanged += new System.EventHandler(this.transportniRadio_CheckedChanged);
            // 
            // BorbeniBrodGroup
            // 
            this.BorbeniBrodGroup.Controls.Add(this.BrojLaserskihTopovaText);
            this.BorbeniBrodGroup.Controls.Add(this.label8);
            this.BorbeniBrodGroup.Controls.Add(this.TipComboBox);
            this.BorbeniBrodGroup.Controls.Add(this.label7);
            this.BorbeniBrodGroup.Controls.Add(this.FotonskoTorpedoCheckBox);
            this.BorbeniBrodGroup.Enabled = false;
            this.BorbeniBrodGroup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorbeniBrodGroup.Location = new System.Drawing.Point(25, 76);
            this.BorbeniBrodGroup.Name = "BorbeniBrodGroup";
            this.BorbeniBrodGroup.Size = new System.Drawing.Size(200, 178);
            this.BorbeniBrodGroup.TabIndex = 15;
            this.BorbeniBrodGroup.TabStop = false;
            this.BorbeniBrodGroup.Text = "Borbeni brod";
            this.BorbeniBrodGroup.Enter += new System.EventHandler(this.BorbeniBrodGroup_Enter);
            // 
            // BrojLaserskihTopovaText
            // 
            this.BrojLaserskihTopovaText.Location = new System.Drawing.Point(117, 67);
            this.BrojLaserskihTopovaText.Name = "BrojLaserskihTopovaText";
            this.BrojLaserskihTopovaText.Size = new System.Drawing.Size(68, 20);
            this.BrojLaserskihTopovaText.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tip broda";
            // 
            // TipComboBox
            // 
            this.TipComboBox.FormattingEnabled = true;
            this.TipComboBox.Items.AddRange(new object[] {
            "Fregata",
            "Razarac",
            "Krstarica"});
            this.TipComboBox.Location = new System.Drawing.Point(9, 124);
            this.TipComboBox.Name = "TipComboBox";
            this.TipComboBox.Size = new System.Drawing.Size(113, 21);
            this.TipComboBox.TabIndex = 3;
            this.TipComboBox.SelectedIndexChanged += new System.EventHandler(this.TipComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Broj laserskih topova";
            // 
            // FotonskoTorpedoCheckBox
            // 
            this.FotonskoTorpedoCheckBox.AutoSize = true;
            this.FotonskoTorpedoCheckBox.Location = new System.Drawing.Point(9, 30);
            this.FotonskoTorpedoCheckBox.Name = "FotonskoTorpedoCheckBox";
            this.FotonskoTorpedoCheckBox.Size = new System.Drawing.Size(109, 17);
            this.FotonskoTorpedoCheckBox.TabIndex = 0;
            this.FotonskoTorpedoCheckBox.Text = "Fotonsko torpedo";
            this.FotonskoTorpedoCheckBox.UseVisualStyleBackColor = true;
            this.FotonskoTorpedoCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TransportniBrodGroup
            // 
            this.TransportniBrodGroup.Controls.Add(this.NosivostText);
            this.TransportniBrodGroup.Controls.Add(this.label9);
            this.TransportniBrodGroup.Controls.Add(this.ZASTITNAOTPLATA);
            this.TransportniBrodGroup.Enabled = false;
            this.TransportniBrodGroup.ForeColor = System.Drawing.SystemColors.Control;
            this.TransportniBrodGroup.Location = new System.Drawing.Point(231, 76);
            this.TransportniBrodGroup.Name = "TransportniBrodGroup";
            this.TransportniBrodGroup.Size = new System.Drawing.Size(200, 178);
            this.TransportniBrodGroup.TabIndex = 14;
            this.TransportniBrodGroup.TabStop = false;
            this.TransportniBrodGroup.Text = "Transportni brod";
            // 
            // NosivostText
            // 
            this.NosivostText.Location = new System.Drawing.Point(100, 67);
            this.NosivostText.Name = "NosivostText";
            this.NosivostText.Size = new System.Drawing.Size(68, 20);
            this.NosivostText.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nosivost";
            // 
            // ZASTITNAOTPLATA
            // 
            this.ZASTITNAOTPLATA.AutoSize = true;
            this.ZASTITNAOTPLATA.Location = new System.Drawing.Point(23, 30);
            this.ZASTITNAOTPLATA.Name = "ZASTITNAOTPLATA";
            this.ZASTITNAOTPLATA.Size = new System.Drawing.Size(99, 17);
            this.ZASTITNAOTPLATA.TabIndex = 0;
            this.ZASTITNAOTPLATA.Text = "Zaštitna otplata";
            this.ZASTITNAOTPLATA.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PosadaIdText);
            this.groupBox1.Controls.Add(this.MaxWarpBrzinaText);
            this.groupBox1.Controls.Add(this.NazivText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(22, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 221);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnove broda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // PosadaIdText
            // 
            this.PosadaIdText.Location = new System.Drawing.Point(97, 111);
            this.PosadaIdText.Name = "PosadaIdText";
            this.PosadaIdText.Size = new System.Drawing.Size(100, 20);
            this.PosadaIdText.TabIndex = 9;
            // 
            // MaxWarpBrzinaText
            // 
            this.MaxWarpBrzinaText.Location = new System.Drawing.Point(97, 85);
            this.MaxWarpBrzinaText.Name = "MaxWarpBrzinaText";
            this.MaxWarpBrzinaText.Size = new System.Drawing.Size(100, 20);
            this.MaxWarpBrzinaText.TabIndex = 7;
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
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Max warp brzina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Posada";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.BorbeniBrodGroup);
            this.groupBox4.Controls.Add(this.TransportniBrodGroup);
            this.groupBox4.Controls.Add(this.transportniRadio);
            this.groupBox4.Controls.Add(this.borbeniRadio);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(267, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(448, 272);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Specijalizacija";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tip broda";
            // 
            // borbeniRadio
            // 
            this.borbeniRadio.AutoSize = true;
            this.borbeniRadio.Location = new System.Drawing.Point(75, 53);
            this.borbeniRadio.Name = "borbeniRadio";
            this.borbeniRadio.Size = new System.Drawing.Size(61, 17);
            this.borbeniRadio.TabIndex = 16;
            this.borbeniRadio.TabStop = true;
            this.borbeniRadio.Text = "Borbeni";
            this.borbeniRadio.UseVisualStyleBackColor = true;
            this.borbeniRadio.CheckedChanged += new System.EventHandler(this.borbeniRadio_CheckedChanged);
            // 
            // KonstrukcijaBrodaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(883, 315);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Konstruisi);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KonstrukcijaBrodaForma";
            this.Text = "KonstrukcijaBrodaForma";
            this.BorbeniBrodGroup.ResumeLayout(false);
            this.BorbeniBrodGroup.PerformLayout();
            this.TransportniBrodGroup.ResumeLayout(false);
            this.TransportniBrodGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Konstruisi;
        private System.Windows.Forms.RadioButton transportniRadio;
        private System.Windows.Forms.GroupBox BorbeniBrodGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox TipComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox FotonskoTorpedoCheckBox;
        private System.Windows.Forms.GroupBox TransportniBrodGroup;
        private System.Windows.Forms.TextBox NosivostText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ZASTITNAOTPLATA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PosadaIdText;
        private System.Windows.Forms.TextBox MaxWarpBrzinaText;
        private System.Windows.Forms.TextBox NazivText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BrojLaserskihTopovaText;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton borbeniRadio;
    }
}