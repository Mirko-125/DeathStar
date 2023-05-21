namespace DeathStar_new.Forme
{
    partial class SpisakOruzjaForma
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
            this.label1 = new System.Windows.Forms.Label();
            this.OruzjeText = new System.Windows.Forms.TextBox();
            this.dodajButton = new System.Windows.Forms.Button();
            this.Gradovi = new System.Windows.Forms.GroupBox();
            this.OruzjaView = new System.Windows.Forms.ListView();
            this.Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gradovi.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(77, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Naziv";
            // 
            // OruzjeText
            // 
            this.OruzjeText.Location = new System.Drawing.Point(25, 338);
            this.OruzjeText.Name = "OruzjeText";
            this.OruzjeText.Size = new System.Drawing.Size(150, 20);
            this.OruzjeText.TabIndex = 6;
            // 
            // dodajButton
            // 
            this.dodajButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dodajButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dodajButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dodajButton.Font = new System.Drawing.Font("Consolas", 14F);
            this.dodajButton.ForeColor = System.Drawing.SystemColors.Control;
            this.dodajButton.Location = new System.Drawing.Point(25, 381);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(150, 49);
            this.dodajButton.TabIndex = 5;
            this.dodajButton.Text = "Dodaj!";
            this.dodajButton.UseVisualStyleBackColor = false;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // Gradovi
            // 
            this.Gradovi.Controls.Add(this.OruzjaView);
            this.Gradovi.ForeColor = System.Drawing.SystemColors.Control;
            this.Gradovi.Location = new System.Drawing.Point(12, 12);
            this.Gradovi.Name = "Gradovi";
            this.Gradovi.Size = new System.Drawing.Size(173, 298);
            this.Gradovi.TabIndex = 4;
            this.Gradovi.TabStop = false;
            this.Gradovi.Text = "Oruzja";
            // 
            // OruzjaView
            // 
            this.OruzjaView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naziv});
            this.OruzjaView.FullRowSelect = true;
            this.OruzjaView.GridLines = true;
            this.OruzjaView.HideSelection = false;
            this.OruzjaView.Location = new System.Drawing.Point(14, 36);
            this.OruzjaView.Name = "OruzjaView";
            this.OruzjaView.Size = new System.Drawing.Size(145, 245);
            this.OruzjaView.TabIndex = 0;
            this.OruzjaView.UseCompatibleStateImageBehavior = false;
            this.OruzjaView.View = System.Windows.Forms.View.Details;
            // 
            // Naziv
            // 
            this.Naziv.Text = "";
            this.Naziv.Width = 137;
            // 
            // SpisakOruzjaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(206, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OruzjeText);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.Gradovi);
            this.Name = "SpisakOruzjaForma";
            this.Text = "SpisakOruzjaForma";
            this.Load += new System.EventHandler(this.SpisakOruzjaForma_Load);
            this.Gradovi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OruzjeText;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.GroupBox Gradovi;
        private System.Windows.Forms.ListView OruzjaView;
        private System.Windows.Forms.ColumnHeader Naziv;
    }
}