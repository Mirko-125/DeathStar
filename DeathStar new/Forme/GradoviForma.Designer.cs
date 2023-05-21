namespace DeathStar_new.Forme
{
    partial class GradoviForma
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
            this.Gradovi = new System.Windows.Forms.GroupBox();
            this.GradoviView = new System.Windows.Forms.ListView();
            this.dodajButton = new System.Windows.Forms.Button();
            this.GradText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gradovi.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gradovi
            // 
            this.Gradovi.Controls.Add(this.GradoviView);
            this.Gradovi.ForeColor = System.Drawing.SystemColors.Control;
            this.Gradovi.Location = new System.Drawing.Point(12, 12);
            this.Gradovi.Name = "Gradovi";
            this.Gradovi.Size = new System.Drawing.Size(173, 298);
            this.Gradovi.TabIndex = 0;
            this.Gradovi.TabStop = false;
            this.Gradovi.Text = "Gradovi";
            // 
            // GradoviView
            // 
            this.GradoviView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naziv});
            this.GradoviView.FullRowSelect = true;
            this.GradoviView.GridLines = true;
            this.GradoviView.HideSelection = false;
            this.GradoviView.Location = new System.Drawing.Point(14, 36);
            this.GradoviView.Name = "GradoviView";
            this.GradoviView.Size = new System.Drawing.Size(145, 245);
            this.GradoviView.TabIndex = 0;
            this.GradoviView.UseCompatibleStateImageBehavior = false;
            this.GradoviView.View = System.Windows.Forms.View.Details;
            // 
            // dodajButton
            // 
            this.dodajButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.dodajButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dodajButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dodajButton.Font = new System.Drawing.Font("Consolas", 14F);
            this.dodajButton.ForeColor = System.Drawing.SystemColors.Control;
            this.dodajButton.Location = new System.Drawing.Point(21, 371);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(150, 49);
            this.dodajButton.TabIndex = 1;
            this.dodajButton.Text = "Dodaj!";
            this.dodajButton.UseVisualStyleBackColor = false;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // GradText
            // 
            this.GradText.Location = new System.Drawing.Point(21, 338);
            this.GradText.Name = "GradText";
            this.GradText.Size = new System.Drawing.Size(150, 20);
            this.GradText.TabIndex = 2;
            this.GradText.TextChanged += new System.EventHandler(this.GradText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(73, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naziv";
            // 
            // Naziv
            // 
            this.Naziv.Text = "";
            this.Naziv.Width = 137;
            // 
            // GradoviForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(209, 432);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GradText);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.Gradovi);
            this.Name = "GradoviForma";
            this.Text = "b";
            this.Load += new System.EventHandler(this.GradoviForma_Load);
            this.Gradovi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gradovi;
        private System.Windows.Forms.ListView GradoviView;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.TextBox GradText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Naziv;
    }
}