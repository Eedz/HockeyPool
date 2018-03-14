namespace HockeyPool
{
    partial class EnterBet
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmdAwayTeam = new System.Windows.Forms.Button();
            this.cmdHomeTeam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(22, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(262, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Wanna make a bet!?";
            // 
            // cmdAwayTeam
            // 
            this.cmdAwayTeam.Location = new System.Drawing.Point(101, 118);
            this.cmdAwayTeam.Name = "cmdAwayTeam";
            this.cmdAwayTeam.Size = new System.Drawing.Size(90, 37);
            this.cmdAwayTeam.TabIndex = 4;
            this.cmdAwayTeam.Text = "Away Team";
            this.cmdAwayTeam.UseVisualStyleBackColor = true;
            this.cmdAwayTeam.Click += new System.EventHandler(this.cmdAwayTeam_Click);
            // 
            // cmdHomeTeam
            // 
            this.cmdHomeTeam.Location = new System.Drawing.Point(101, 181);
            this.cmdHomeTeam.Name = "cmdHomeTeam";
            this.cmdHomeTeam.Size = new System.Drawing.Size(90, 37);
            this.cmdHomeTeam.TabIndex = 5;
            this.cmdHomeTeam.Text = "Home Team";
            this.cmdHomeTeam.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "at";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "$ Bet";
            // 
            // EnterBet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 248);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdHomeTeam);
            this.Controls.Add(this.cmdAwayTeam);
            this.Controls.Add(this.lblTitle);
            this.Name = "EnterBet";
            this.Text = "EnterBet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button cmdAwayTeam;
        private System.Windows.Forms.Button cmdHomeTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}