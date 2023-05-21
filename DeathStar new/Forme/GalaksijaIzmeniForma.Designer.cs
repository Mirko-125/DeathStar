namespace DeathStar_new.Forme
{
    partial class GalaksijaIzmeniForma
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
            this.azurirajBtn = new System.Windows.Forms.Button();
            this.Podaci = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textDominatnaRasa = new System.Windows.Forms.TextBox();
            this.textBrojZvezda = new System.Windows.Forms.TextBox();
            this.textBrojPlaneta = new System.Windows.Forms.TextBox();
            this.Podaci.SuspendLayout();
            this.SuspendLayout();
            // 
            // azurirajBtn
            // 
            this.azurirajBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.azurirajBtn.Font = new System.Drawing.Font("Consolas", 14F);
            this.azurirajBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.azurirajBtn.Location = new System.Drawing.Point(121, 161);
            this.azurirajBtn.Name = "azurirajBtn";
            this.azurirajBtn.Size = new System.Drawing.Size(140, 76);
            this.azurirajBtn.TabIndex = 12;
            this.azurirajBtn.Text = "Ažuriraj";
            this.azurirajBtn.UseVisualStyleBackColor = false;
            this.azurirajBtn.Click += new System.EventHandler(this.azurirajBtn_Click);
            // 
            // Podaci
            // 
            this.Podaci.Controls.Add(this.label4);
            this.Podaci.Controls.Add(this.label3);
            this.Podaci.Controls.Add(this.label2);
            this.Podaci.Controls.Add(this.textDominatnaRasa);
            this.Podaci.Controls.Add(this.textBrojZvezda);
            this.Podaci.Controls.Add(this.textBrojPlaneta);
            this.Podaci.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Podaci.Location = new System.Drawing.Point(12, 12);
            this.Podaci.Name = "Podaci";
            this.Podaci.Size = new System.Drawing.Size(249, 127);
            this.Podaci.TabIndex = 11;
            this.Podaci.TabStop = false;
            this.Podaci.Text = "Podaci";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Location = new System.Drawing.Point(21, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dominatna rasa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Location = new System.Drawing.Point(21, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Broj zvezda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Location = new System.Drawing.Point(21, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Broj planeta";
            // 
            // textDominatnaRasa
            // 
            this.textDominatnaRasa.Location = new System.Drawing.Point(110, 84);
            this.textDominatnaRasa.Name = "textDominatnaRasa";
            this.textDominatnaRasa.Size = new System.Drawing.Size(121, 20);
            this.textDominatnaRasa.TabIndex = 4;
            // 
            // textBrojZvezda
            // 
            this.textBrojZvezda.Location = new System.Drawing.Point(110, 56);
            this.textBrojZvezda.Name = "textBrojZvezda";
            this.textBrojZvezda.Size = new System.Drawing.Size(121, 20);
            this.textBrojZvezda.TabIndex = 2;
            // 
            // textBrojPlaneta
            // 
            this.textBrojPlaneta.Location = new System.Drawing.Point(110, 28);
            this.textBrojPlaneta.Name = "textBrojPlaneta";
            this.textBrojPlaneta.Size = new System.Drawing.Size(121, 20);
            this.textBrojPlaneta.TabIndex = 1;
            // 
            // GalaksijaIzmeniForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(287, 261);
            this.Controls.Add(this.azurirajBtn);
            this.Controls.Add(this.Podaci);
            this.Name = "GalaksijaIzmeniForma";
            this.Text = "GalaksijaIzmeniForma";
            this.Load += new System.EventHandler(this.GalaksijaIzmeniForma_Load);
            this.Podaci.ResumeLayout(false);
            this.Podaci.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button azurirajBtn;
        private System.Windows.Forms.GroupBox Podaci;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDominatnaRasa;
        private System.Windows.Forms.TextBox textBrojZvezda;
        private System.Windows.Forms.TextBox textBrojPlaneta;
    }
}