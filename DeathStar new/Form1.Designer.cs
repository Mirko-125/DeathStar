namespace DeathStar_new
{
    partial class Form1
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
            this.findGalaxy = new System.Windows.Forms.Button();
            this.showPlayers = new System.Windows.Forms.Button();
            this.dodajOsvajanje = new System.Windows.Forms.Button();
            this.brodoviPosade = new System.Windows.Forms.Button();
            this.osvojiPlanetu = new System.Windows.Forms.Button();
            this.showSatelitiAndStations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // findGalaxy
            // 
            this.findGalaxy.Location = new System.Drawing.Point(54, 32);
            this.findGalaxy.Name = "findGalaxy";
            this.findGalaxy.Size = new System.Drawing.Size(75, 23);
            this.findGalaxy.TabIndex = 0;
            this.findGalaxy.Text = "button1";
            this.findGalaxy.UseVisualStyleBackColor = true;
            this.findGalaxy.Click += new System.EventHandler(this.findGalaxy_Click);
            // 
            // showPlayers
            // 
            this.showPlayers.Location = new System.Drawing.Point(12, 74);
            this.showPlayers.Name = "showPlayers";
            this.showPlayers.Size = new System.Drawing.Size(142, 47);
            this.showPlayers.TabIndex = 1;
            this.showPlayers.Text = "prikazi igrace";
            this.showPlayers.UseVisualStyleBackColor = true;
            this.showPlayers.Click += new System.EventHandler(this.showPlayers_Click);
            // 
            // dodajOsvajanje
            // 
            this.dodajOsvajanje.Location = new System.Drawing.Point(12, 127);
            this.dodajOsvajanje.Name = "dodajOsvajanje";
            this.dodajOsvajanje.Size = new System.Drawing.Size(142, 38);
            this.dodajOsvajanje.TabIndex = 2;
            this.dodajOsvajanje.Text = "DODAJ OSVAJANJE";
            this.dodajOsvajanje.UseVisualStyleBackColor = true;
            this.dodajOsvajanje.Click += new System.EventHandler(this.dodajOsvajanje_Click);
            // 
            // brodoviPosade
            // 
            this.brodoviPosade.Location = new System.Drawing.Point(12, 185);
            this.brodoviPosade.Name = "brodoviPosade";
            this.brodoviPosade.Size = new System.Drawing.Size(127, 39);
            this.brodoviPosade.TabIndex = 3;
            this.brodoviPosade.Text = "brodoviPosade";
            this.brodoviPosade.UseVisualStyleBackColor = true;
            this.brodoviPosade.Click += new System.EventHandler(this.brodoviPosade_Click);
            // 
            // osvojiPlanetu
            // 
            this.osvojiPlanetu.Location = new System.Drawing.Point(9, 243);
            this.osvojiPlanetu.Name = "osvojiPlanetu";
            this.osvojiPlanetu.Size = new System.Drawing.Size(130, 46);
            this.osvojiPlanetu.TabIndex = 4;
            this.osvojiPlanetu.Text = "osvoji planetu";
            this.osvojiPlanetu.UseVisualStyleBackColor = true;
            this.osvojiPlanetu.Click += new System.EventHandler(this.osvojiPlanetu_Click);
            // 
            // showSatelitiAndStations
            // 
            this.showSatelitiAndStations.Location = new System.Drawing.Point(13, 323);
            this.showSatelitiAndStations.Name = "showSatelitiAndStations";
            this.showSatelitiAndStations.Size = new System.Drawing.Size(126, 43);
            this.showSatelitiAndStations.TabIndex = 5;
            this.showSatelitiAndStations.Text = "pokaziSateliteIStanice";
            this.showSatelitiAndStations.UseVisualStyleBackColor = true;
            this.showSatelitiAndStations.Click += new System.EventHandler(this.showSatelitiAndStations_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showSatelitiAndStations);
            this.Controls.Add(this.osvojiPlanetu);
            this.Controls.Add(this.brodoviPosade);
            this.Controls.Add(this.dodajOsvajanje);
            this.Controls.Add(this.showPlayers);
            this.Controls.Add(this.findGalaxy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button findGalaxy;
        private System.Windows.Forms.Button showPlayers;
        private System.Windows.Forms.Button dodajOsvajanje;
        private System.Windows.Forms.Button brodoviPosade;
        private System.Windows.Forms.Button osvojiPlanetu;
        private System.Windows.Forms.Button showSatelitiAndStations;
    }
}

